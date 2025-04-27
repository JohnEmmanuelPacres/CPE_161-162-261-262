using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Pacres_BasicCalculator
{
    public partial class BasicCalculator : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        private double memory;
        public bool memFlag;
        private bool opFlag = false;
        public BasicCalculator()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }
        private void BasicCalculator_Load(object sender, EventArgs e)
        {
            FrontEndStyle();
        }
        private void FrontEndStyle()
        {
            var buttons = new Button[] { btnMC, btnMR, btnMS, btnM_minus, btnM_plus, btn0, btn1, btn2, btn3,
                btn4, btn5, btn6, btn7, btn8, btn9, btnDecimal, btnClear, btnBackspace, btnPlus, btnMinus,
                btnDivide, btnTimes, btnPlusMinus, btnEquals, btnOpen, btnClose};
            foreach (var btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.FromArgb(100, 142, 68, 173);
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.Yellow;
                btn.FlatAppearance.MouseOverBackColor = Color.Gold;
                btn.FlatAppearance.MouseDownBackColor = Color.RebeccaPurple;
            }
        }
        private void btnNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtDisplay.Text == "0" || txtDisplay.Text == "Syntax Error" ||
                txtDisplay.Text == "Math Error: Unable to Divide By Zero" || txtDisplay.Text == "Memory Error" ||
                txtDisplay.Text == "Math Error: Too Large Result" || txtDisplay.Text == "Syntax Error: Unbalanced Parentheses" ||
                opFlag || memFlag)
            {
                txtDisplay.Text = num.Text;
                opFlag = false;
                memFlag = false;
                return;
            }
            txtDisplay.Text += num.Text;
        }
        private void btnOperators(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "Syntax Error")
                return;

            if (txtDisplay.Text.EndsWith("+") || txtDisplay.Text.EndsWith("-") ||
                txtDisplay.Text.EndsWith("×") || txtDisplay.Text.EndsWith("÷") ||
                txtDisplay.Text.EndsWith("("))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }

            txtDisplay.Text += op.Text;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "Math Error: Unable to Divide By Zero" || txtDisplay.Text == "Syntax Error" ||
                txtDisplay.Text == "Memory Error" || txtDisplay.Text == "Math Error: Too Large Result" ||
                txtDisplay.Text == "Syntax Error: Unbalanced Parentheses")
            {
                txtDisplay.Text = "0";
                result = 0;
                operation = "";
            }
            else if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }

            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                int openCount = txtDisplay.Text.Count(c => c == '(');
                int closeCount = txtDisplay.Text.Count(c => c == ')');

                if (openCount != closeCount)
                {
                    txtDisplay.Text = "Syntax Error: Unbalanced Parentheses";
                    return;
                }
                double result = EvaluateExpression(txtDisplay.Text);
                txtDisplay.Text = result.ToString();
                if (txtDisplay.Text == "∞")
                {
                    throw new DivideByZeroException();
                }
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Math Error: Unable to Divide By Zero";
            }
            catch (OverflowException)
            {
                txtDisplay.Text = "Math Error: Too Large Result";
            }
            catch (Exception)
            {
                txtDisplay.Text = "Syntax Error";
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Button btnOpen = sender as Button;
            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text.EndsWith("+") || txtDisplay.Text.EndsWith("-") ||
                txtDisplay.Text.EndsWith("×") || txtDisplay.Text.EndsWith("÷") || txtDisplay.Text.EndsWith("("))
            {
                txtDisplay.Text += "(";
            }
            else if (char.IsDigit(txtDisplay.Text.Last()) || txtDisplay.Text.EndsWith(")"))
            {
                txtDisplay.Text += "×(";
            }
            else
            {
                txtDisplay.Text += "(";
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Button btnClose = sender as Button;
            int openParenthesesCount = txtDisplay.Text.Count(c => c == '(');
            int closeParenthesesCount = txtDisplay.Text.Count(c => c == ')');
            if (openParenthesesCount > closeParenthesesCount &&
                (char.IsDigit(txtDisplay.Text.Last()) || txtDisplay.Text.EndsWith(")")))
            {
                txtDisplay.Text += ")";
            }
        }
        private double EvaluateExpression(string expression)
        {
            expression = expression.Replace("×", "*").Replace("÷", "/");
            var result = new System.Data.DataTable().Compute(expression, null);
            return Convert.ToDouble(result);
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != "0")
            {
                string currentText = txtDisplay.Text;
                string[] parts = currentText.Split(new char[] { '+', '-', '×', '÷' },
                    StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0)
                {
                    if (parts.Length == 1)
                    {
                        if (currentText.StartsWith("-"))
                        {
                            currentText = currentText.Substring(1);
                        }
                        else
                        {
                            currentText = "-" + currentText;
                        }
                    }
                    else
                    {
                        string lastPart = parts.Last();
                        if (!string.IsNullOrEmpty(lastPart))
                        {
                            int lastIndex = currentText.LastIndexOf(lastPart);
                            if (lastIndex > 0 && currentText[lastIndex - 1] == '-' || 
                                lastIndex > 0 && currentText[lastIndex - 1] == '÷' + '-' ||
                                lastIndex > 0 && currentText[lastIndex - 1] == '×' + '-')
                            {
                                currentText = currentText.Substring(0, lastIndex - 1) + "+" + lastPart;
                            }
                            else if (lastIndex > 0 && currentText[lastIndex - 1] == '+' ||
                                lastIndex > 0 && currentText[lastIndex - 1] == '÷' + ' ' ||
                                lastIndex > 0 && currentText[lastIndex - 1] == '÷' + '+' ||
                                lastIndex > 0 && currentText[lastIndex - 1] == '×' + ' ' ||
                                lastIndex > 0 && currentText[lastIndex - 1] == '×' + '+')
                            {
                                currentText = currentText.Substring(0, lastIndex - 1) + "-" + lastPart;
                            }
                            else
                            {
                                currentText = currentText.Substring(0, lastIndex) + "-" + lastPart;
                            }
                        }
                    }
                }
                txtDisplay.Text = currentText;
            }
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            try
            {
                memory = Double.Parse(txtDisplay.Text);
                btnMC.Enabled = true;
                btnMR.Enabled = true;
                memFlag = true;
            }
            catch (FormatException)
            {
                txtDisplay.Text = "Memory Error";
            }
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "Math Error: Unable to Divide By Zero" || txtDisplay.Text == "Syntax Error" ||
                txtDisplay.Text == "Memory Error" || txtDisplay.Text == "Math Error: Too Large Result" ||
                txtDisplay.Text == "Syntax Error: Unbalanced Parentheses" || txtDisplay.Text == "0")
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (char.IsDigit(txtDisplay.Text.Last()))
            {
                txtDisplay.Clear();
                txtDisplay.Text += memory.ToString();
            }
            else
            {
                txtDisplay.Text += memory.ToString();
            }
        }
        private void btnMC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }
        private void btnM_plus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtDisplay.Text);
        }
        private void btnM_minus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtDisplay.Text);
        }

        private void Keyboard_Paint(object sender, PaintEventArgs e)
        {
            Keyboard.BackColor = Color.Purple;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.EndsWith(".") && !CurrentNumberContainsDecimal())
            {
                if (string.IsNullOrEmpty(txtDisplay.Text) ||
                    txtDisplay.Text == "0" || opFlag)
                {
                    txtDisplay.Clear();
                    txtDisplay.Text += "0.";
                }
                else
                {
                    txtDisplay.Text += ".";
                }
                opFlag = false;
            }
        }

        private bool CurrentNumberContainsDecimal()
        {
            int lastOperatorIndex = txtDisplay.Text.LastIndexOfAny(new char[] { '+', '-', '×', '÷', '(', ')' });
            string currentSegment = lastOperatorIndex >= 0
                ? txtDisplay.Text.Substring(lastOperatorIndex + 1)
                : txtDisplay.Text;
            return currentSegment.Contains(".");
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}