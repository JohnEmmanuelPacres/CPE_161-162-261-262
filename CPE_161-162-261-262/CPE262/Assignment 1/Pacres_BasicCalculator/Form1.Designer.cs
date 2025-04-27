namespace Pacres_BasicCalculator
{
    partial class BasicCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicCalculator));
            txtDisplay = new TextBox();
            btnMC = new Button();
            btnMR = new Button();
            btnM_minus = new Button();
            btnM_plus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnEquals = new Button();
            btnMS = new Button();
            btnClose = new Button();
            btnOpen = new Button();
            btnPlusMinus = new Button();
            Keyboard = new TableLayoutPanel();
            Keyboard.SuspendLayout();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.InactiveCaption;
            txtDisplay.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.WindowText;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(469, 89);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnMC
            // 
            btnMC.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnMC.ForeColor = SystemColors.ActiveBorder;
            btnMC.Location = new Point(161, 3);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(72, 37);
            btnMC.TabIndex = 1;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnMR.ForeColor = SystemColors.ActiveBorder;
            btnMR.Location = new Point(240, 3);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(69, 37);
            btnMR.TabIndex = 2;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // btnM_minus
            // 
            btnM_minus.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnM_minus.ForeColor = SystemColors.ActiveBorder;
            btnM_minus.Location = new Point(82, 3);
            btnM_minus.Name = "btnM_minus";
            btnM_minus.Size = new Size(73, 37);
            btnM_minus.TabIndex = 3;
            btnM_minus.Text = "M-";
            btnM_minus.UseVisualStyleBackColor = true;
            btnM_minus.Click += btnM_minus_Click;
            // 
            // btnM_plus
            // 
            btnM_plus.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnM_plus.ForeColor = SystemColors.ActiveBorder;
            btnM_plus.Location = new Point(3, 3);
            btnM_plus.Name = "btnM_plus";
            btnM_plus.Size = new Size(69, 37);
            btnM_plus.TabIndex = 4;
            btnM_plus.Text = "M+";
            btnM_plus.UseVisualStyleBackColor = true;
            btnM_plus.Click += btnM_plus_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Century Gothic", 19.8000011F);
            btn7.ForeColor = SystemColors.ActiveBorder;
            btn7.Location = new Point(3, 47);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 73);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Century Gothic", 19.8000011F);
            btn8.ForeColor = SystemColors.ActiveBorder;
            btn8.Location = new Point(82, 47);
            btn8.Name = "btn8";
            btn8.Size = new Size(73, 73);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Century Gothic", 19.8000011F);
            btn9.ForeColor = SystemColors.ActiveBorder;
            btn9.Location = new Point(161, 47);
            btn9.Name = "btn9";
            btn9.Size = new Size(72, 73);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Century Gothic", 19.8000011F);
            btn6.ForeColor = SystemColors.ActiveBorder;
            btn6.Location = new Point(161, 133);
            btn6.Name = "btn6";
            btn6.Size = new Size(72, 73);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Century Gothic", 19.8000011F);
            btn5.ForeColor = SystemColors.ActiveBorder;
            btn5.Location = new Point(82, 133);
            btn5.Name = "btn5";
            btn5.Size = new Size(73, 73);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("Century Gothic", 19.8000011F);
            btn4.ForeColor = SystemColors.ActiveBorder;
            btn4.Location = new Point(3, 133);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 73);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Century Gothic", 19.8000011F);
            btn3.ForeColor = SystemColors.ActiveBorder;
            btn3.Location = new Point(3, 215);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 73);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Century Gothic", 19.8000011F);
            btn2.ForeColor = SystemColors.ActiveBorder;
            btn2.Location = new Point(82, 215);
            btn2.Name = "btn2";
            btn2.Size = new Size(73, 73);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Century Gothic", 19.8000011F);
            btn1.ForeColor = SystemColors.ActiveBorder;
            btn1.Location = new Point(161, 215);
            btn1.Name = "btn1";
            btn1.Size = new Size(73, 73);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumbers;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Century Gothic", 19.8000011F);
            btnDecimal.ForeColor = SystemColors.ActiveBorder;
            btnDecimal.Location = new Point(161, 295);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(73, 72);
            btnDecimal.TabIndex = 16;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Century Gothic", 19.8000011F);
            btn0.ForeColor = SystemColors.ActiveBorder;
            btn0.Location = new Point(82, 295);
            btn0.Name = "btn0";
            btn0.Size = new Size(73, 72);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumbers;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Century Gothic", 19.8000011F);
            btnClear.ForeColor = SystemColors.ActiveBorder;
            btnClear.Location = new Point(3, 295);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 72);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Anchor = AnchorStyles.Right;
            btnBackspace.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBackspace.BackColor = SystemColors.InactiveCaptionText;
            btnBackspace.Font = new Font("Century Gothic", 19.8000011F);
            btnBackspace.ForeColor = SystemColors.GrayText;
            btnBackspace.Location = new Point(415, 118);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(68, 120);
            btnBackspace.TabIndex = 18;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Century Gothic", 19.8000011F);
            btnDivide.ForeColor = SystemColors.ActiveBorder;
            btnDivide.Location = new Point(319, 133);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 73);
            btnDivide.TabIndex = 20;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperators;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Century Gothic", 19.8000011F);
            btnTimes.ForeColor = SystemColors.ActiveBorder;
            btnTimes.Location = new Point(240, 133);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(73, 73);
            btnTimes.TabIndex = 19;
            btnTimes.Text = "×";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnOperators;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Century Gothic", 19.8000011F);
            btnPlus.ForeColor = SystemColors.ActiveBorder;
            btnPlus.Location = new Point(240, 295);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(73, 72);
            btnPlus.TabIndex = 22;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperators;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Century Gothic", 19.8000011F);
            btnMinus.ForeColor = SystemColors.ActiveBorder;
            btnMinus.Location = new Point(240, 215);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(73, 73);
            btnMinus.TabIndex = 21;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperators;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Century Gothic", 19.8000011F);
            btnEquals.ForeColor = SystemColors.ActiveBorder;
            btnEquals.Location = new Point(319, 295);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(68, 72);
            btnEquals.TabIndex = 23;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnMS
            // 
            btnMS.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnMS.ForeColor = SystemColors.ActiveBorder;
            btnMS.Location = new Point(319, 3);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(68, 37);
            btnMS.TabIndex = 24;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Century Gothic", 19.8000011F);
            btnClose.ForeColor = SystemColors.ActiveBorder;
            btnClose.Location = new Point(319, 47);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(68, 73);
            btnClose.TabIndex = 26;
            btnClose.Text = ")";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Century Gothic", 19.8000011F);
            btnOpen.ForeColor = SystemColors.ActiveBorder;
            btnOpen.Location = new Point(240, 47);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(69, 73);
            btnOpen.TabIndex = 25;
            btnOpen.Text = "(";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Font = new Font("Century Gothic", 19.8000011F);
            btnPlusMinus.ForeColor = SystemColors.ActiveBorder;
            btnPlusMinus.Location = new Point(319, 215);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(68, 73);
            btnPlusMinus.TabIndex = 27;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // Keyboard
            // 
            Keyboard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Keyboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Keyboard.BackColor = SystemColors.Desktop;
            Keyboard.BackgroundImage = (Image)resources.GetObject("Keyboard.BackgroundImage");
            Keyboard.ColumnCount = 5;
            Keyboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Keyboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Keyboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Keyboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Keyboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Keyboard.Controls.Add(btnMS, 4, 0);
            Keyboard.Controls.Add(btnM_minus, 1, 0);
            Keyboard.Controls.Add(btnM_plus, 0, 0);
            Keyboard.Controls.Add(btnDivide, 4, 2);
            Keyboard.Controls.Add(btnDecimal, 2, 4);
            Keyboard.Controls.Add(btnMR, 3, 0);
            Keyboard.Controls.Add(btnMinus, 3, 3);
            Keyboard.Controls.Add(btn0, 1, 4);
            Keyboard.Controls.Add(btnClear, 0, 4);
            Keyboard.Controls.Add(btn7, 0, 1);
            Keyboard.Controls.Add(btn8, 1, 1);
            Keyboard.Controls.Add(btn9, 2, 1);
            Keyboard.Controls.Add(btn5, 1, 2);
            Keyboard.Controls.Add(btn6, 2, 2);
            Keyboard.Controls.Add(btnPlus, 3, 4);
            Keyboard.Controls.Add(btn3, 0, 3);
            Keyboard.Controls.Add(btn2, 1, 3);
            Keyboard.Controls.Add(btnTimes, 3, 2);
            Keyboard.Controls.Add(btn1, 2, 3);
            Keyboard.Controls.Add(btnMC, 2, 0);
            Keyboard.Controls.Add(btnPlusMinus, 4, 3);
            Keyboard.Controls.Add(btnOpen, 3, 1);
            Keyboard.Controls.Add(btnClose, 4, 1);
            Keyboard.Controls.Add(btnEquals, 4, 4);
            Keyboard.Controls.Add(btn4, 0, 2);
            Keyboard.Location = new Point(12, 118);
            Keyboard.Name = "Keyboard";
            Keyboard.RowCount = 5;
            Keyboard.RowStyles.Add(new RowStyle(SizeType.Percent, 34.02778F));
            Keyboard.RowStyles.Add(new RowStyle(SizeType.Percent, 65.97222F));
            Keyboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            Keyboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            Keyboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            Keyboard.Size = new Size(397, 378);
            Keyboard.TabIndex = 31;
            Keyboard.Paint += Keyboard_Paint;
            // 
            // BasicCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(492, 516);
            Controls.Add(Keyboard);
            Controls.Add(txtDisplay);
            Controls.Add(btnBackspace);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacres Calculator";
            Load += BasicCalculator_Load;
            Keyboard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnMC;
        private Button btnMR;
        private Button btnM_minus;
        private Button btnM_plus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDecimal;
        private Button btn0;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnDivide;
        private Button btnTimes;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnEquals;
        private Button btnMS;
        private Button btnClose;
        private Button btnOpen;
        private Button btnPlusMinus;
        private TableLayoutPanel Keyboard;
    }
}
