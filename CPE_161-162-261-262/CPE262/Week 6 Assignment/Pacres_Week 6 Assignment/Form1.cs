using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;
using System.Data;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace Pacres_Week_6_Assignment
{
    public partial class Form1 : Form
    {
        List<string> header = new(); //list datatype for adding columns
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            gradient1.RefreshGradient();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            exportData();
        }

        private void exportToolMenuStrip_Click(object sender, EventArgs e)
        {
            exportData();
        }

        private void exportData()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (*.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");
                DataGridViewConverter.ImportFromDataGridView(
                    worksheet, this.dataGridView1, new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                workbook.Save(saveFileDialog.FileName);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void eXITPROGRAMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) 
                || string.IsNullOrWhiteSpace(txtFirstName.Text) 
                || string.IsNullOrWhiteSpace(txtMiddleInitial.Text) 
                || string.IsNullOrWhiteSpace(txtLastName.Text) 
                || string.IsNullOrWhiteSpace(txtAddress.Text) 
                || string.IsNullOrWhiteSpace(txtCollege.Text))
            {
                MessageBox.Show("Please fill up all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(txtStudentID.Text, txtFirstName.Text, txtMiddleInitial.Text, txtLastName.Text, GetSelectedGender(),
                dateTimePicker1.Value.ToShortDateString(), txtAddress.Text, txtCollege.Text); //data table for adding rows
        }

        private string GetSelectedGender()
        {
            if (maleRadioButton.Checked) return "Male";
            if (femaleRadioButton.Checked) return "Female";
            return "N/A";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteThis();
        }

        private void deleteToolMenuStrip_Click(object sender, EventArgs e)
        {
            deleteThis();
        }

        private void deleteThis()
        {
            DialogResult delete = MessageBox.Show("Are you sure to delete selected rows?", "Delete",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (delete == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    if (!item.IsNewRow)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

            iReset();
        }

        private void resetToolMenuStrip_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private void iReset()
        {
            DialogResult affirm = MessageBox.Show("Are you sure to clear all rows?", "Reset",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (affirm == DialogResult.Yes)
            {
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }

                int numRows = dataGridView1.Rows.Count, i;
                for (i = 0; i < numRows; i++)
                {
                    try
                    {
                        int max = dataGridView1.Rows.Count - 1;
                        dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("All rows are to be deleted" + exe, "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += printDocument1_PrintPage;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void importDataToolMenuStrip_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
                "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
                "ODS files (*.ods, *.ots)|*.ods;*.ots|" +
                "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
                "HTML files (*.html, *.htm)|*.html;*.htm";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;
                DataGridViewConverter.ExportToDataGridView(
                    worksheet,
                    this.dataGridView1, new ExportToDataGridViewOptions() { ColumnHeaders = true });
            }
        }

        private void AddColumn(string columnName)
        {
            if (!header.Contains(columnName))
            {
                header.Add(columnName);
                dataGridView1.Columns.Add(columnName, columnName);
            }
            else
            {
                MessageBox.Show("Column already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteColumn(string columnName)
        {
            if (header.Contains(columnName))
            {
                header.Remove(columnName);
                dataGridView1.Columns.Remove(columnName);
            }
            else
            {
                MessageBox.Show("Column not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addColumn_Click(object sender, EventArgs e)
        {
            string columnName = Microsoft.VisualBasic.Interaction.InputBox("Enter column name:", "Add Column", "");
            if (!string.IsNullOrWhiteSpace(columnName))
            {
                AddColumn(columnName);
            }
        }

        private void deleteColumn_Click(object sender, EventArgs e)
        {
            string columnName = Microsoft.VisualBasic.Interaction.InputBox("Enter column name to delete:", "Delete Column", "");
            if (!string.IsNullOrWhiteSpace(columnName))
            {
                DeleteColumn(columnName);
            }
        }

        private void OnResize(object sender, EventArgs e)
        {
            gradient1.RefreshGradient();
        }

        private void OnResizeEnd(object sender, EventArgs e)
        {
            gradient1.RefreshGradient();
        }
    }

    public class Gradient : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }
        public void RefreshGradient()
        {
            this.Invalidate();
        }
    }
}