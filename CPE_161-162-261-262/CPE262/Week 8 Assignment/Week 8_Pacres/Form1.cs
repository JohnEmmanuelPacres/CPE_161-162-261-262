using System.Data.OleDb;
using System.Data;
using System.Net.Http.Headers;

namespace Week_8_Pacres
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        bool Query, Table;
        public Form1()
        {
            InitializeComponent();

            Query = false;
            Table = false;
            panel2.Visible = false;
            lblStudentID.Visible = false;
            lblLastName.Visible = false;
            lblFirstName.Visible = false;
            lblCourse.Visible = false;
            lblYearLevel.Visible = false;
            lblCourse1.Visible = false;
            lblCourse2.Visible = false;
            lblCourse3.Visible = false;
            lblCourse4.Visible = false;
            lblCourse5.Visible = false;

            txtBxStudentID.Visible = false;
            txtBxLastName.Visible = false;
            txtBxFirstName.Visible = false;
            tbxCourse.Visible = false;
            tbxYrLvl.Visible = false;

            tbxCourse1.Visible = false;
            tbxCourse2.Visible = false;
            tbxCourse3.Visible = false;
            tbxCourse4.Visible = false;
            tbxCourse5.Visible = false;

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                " C:\\Users\\jcnru\\Documents\\WEEK 7 AND 8\\Pacres, John Emmanuel_SchoolDatabase.accdb");
        }

        private void ConnectionTest()
        {
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            ConnectionTest();
        }
        private void cONNECTIONTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionTest();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIDesign();
        }

        private void UIDesign()
        {
            var buttons = new Button[] { btnLoadData, btnInsert, btnUpdate, btnDelete, btnConnectionTest };
            foreach (var button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.FromArgb(100, 142, 68, 173);
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.Yellow;
                button.FlatAppearance.MouseOverBackColor = Color.Gold;
                button.FlatAppearance.MouseDownBackColor = Color.RebeccaPurple;
            }
        }

        private void LoadDataDB()
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnLoadData, 0, btnLoadData.Height);
        }
        
        private void LoadData()
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data " +
                    "Source=C:\\Users\\jcnru\\Documents\\WEEK 7 AND 8\\Pacres, John Emmanuel_SchoolDatabase.accdb"))
                {
                    myConn.Open();

                    string query = "";

                    if (Table)
                    {
                        query = "SELECT * FROM Student";
                    }
                    else if (Query)
                    {
                        query = "SELECT Student.StudentID, Student.LastName, Student.FirstName, " +
                                "SubjectsEnrolled.CourseNum1, SubjectsEnrolled.CourseNum2, " +
                                "SubjectsEnrolled.CourseNum3, SubjectsEnrolled.CourseNum4, SubjectsEnrolled.CourseNum5 " +
                                "FROM SubjectsEnrolled " +
                                "INNER JOIN Student ON SubjectsEnrolled.StudentID = Student.StudentID " +
                                "ORDER BY Student.LastName;";
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        da = new OleDbDataAdapter(query, myConn);
                        ds = new DataSet();
                        da.Fill(ds, "Student");
                        dgvStudentInfo.DataSource = ds.Tables["Student"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            txtBxStudentID.Text = row.Cells[0].Value.ToString();
        }

        private void Insert()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBxLastName.Text) || string.IsNullOrWhiteSpace(txtBxFirstName.Text))
                {
                    MessageBox.Show("Please enter Last Name and First Name.", "Input Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }

                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE." +
                    "OLEDB.12.0;Data Source=C:\\Users\\jcnru\\Documents\\WEEK 7 AND 8\\Pacres, " +
                    "John Emmanuel_SchoolDatabase.accdb"))
                {
                    myConn.Open();
                    string studentQuery = "INSERT INTO Student (LastName, FirstName, Course, YearLevel  ) VALUES " +
                        "(@LName, @FName, @Course, @YearLevel)";
                    using (OleDbCommand cmd = new OleDbCommand(studentQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("@LName", txtBxLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@FName", txtBxFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Course", tbxCourse.Text.Trim());
                        cmd.Parameters.AddWithValue("@YearLevel", tbxYrLvl.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    int studentID;
                    using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", myConn))
                    {
                        studentID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    string subjectsQuery = "INSERT INTO SubjectsEnrolled (StudentID, CourseNum1, " +
                        "CourseNum2, CourseNum3, CourseNum4, CourseNum5) " +
                                           "VALUES (@StudentID, @Course1, @Course2, @Course3, @Course4, @Course5)";
                    using (OleDbCommand cmd = new OleDbCommand(subjectsQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Course1", tbxCourse1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Course2", tbxCourse2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Course3", tbxCourse3.Text.Trim());
                        cmd.Parameters.AddWithValue("@Course4", tbxCourse4.Text.Trim());
                        cmd.Parameters.AddWithValue("@Course5", tbxCourse5.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please input again\nError: {ex}", "Error Encountered", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Delete()
        {
            try
            {
                if (dgvStudentInfo.CurrentRow == null)
                {
                    MessageBox.Show("No record selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentID;
                if (!int.TryParse(dgvStudentInfo.CurrentRow.Cells[0].Value.ToString(), out studentID))
                {
                    MessageBox.Show("Invalid Student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult confirmDelete = MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmDelete != DialogResult.Yes)
                {
                    return;
                }

                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=C:\\Users\\jcnru\\Documents\\WEEK 7 AND 8\\Pacres, " +
                    "John Emmanuel_SchoolDatabase.accdb"))
                {
                    myConn.Open();

                    string deleteSubjectsQuery = "DELETE FROM SubjectsEnrolled WHERE StudentID = @id";
                    using (OleDbCommand cmdSubjects = new OleDbCommand(deleteSubjectsQuery, myConn))
                    {
                        cmdSubjects.Parameters.AddWithValue("@id", studentID);
                        cmdSubjects.ExecuteNonQuery();
                    }

                    string deleteStudentQuery = "DELETE FROM Student WHERE StudentID = @id";
                    using (OleDbCommand cmdStudent = new OleDbCommand(deleteStudentQuery, myConn))
                    {
                        cmdStudent.Parameters.AddWithValue("@id", studentID);
                        int rowsAffected = cmdStudent.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. Student ID not found.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Encountered", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Update()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBxStudentID.Text))
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtBxStudentID.Text, out int studentID))
                {
                    MessageBox.Show("Invalid Student ID!", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbxYrLvl.Text.Trim(), out int yearLevel))
                {
                    MessageBox.Show("Invalid Year Level!", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }

                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=C:\\Users\\jcnru\\Documents\\WEEK 7 AND 8\\Pacres, " +
                    "John Emmanuel_SchoolDatabase.accdb"))
                {
                    myConn.Open();

                    if (Table)
                    {
                        string studentQuery = "UPDATE Student SET LastName = ?, FirstName = ?, " +
                            "Course = ?, YearLevel = ? WHERE StudentID = ?";

                        using (OleDbCommand cmdStudent = new OleDbCommand(studentQuery, myConn))
                        {
                            cmdStudent.Parameters.AddWithValue("?", txtBxLastName.Text.Trim());
                            cmdStudent.Parameters.AddWithValue("?", txtBxFirstName.Text.Trim());
                            cmdStudent.Parameters.AddWithValue("?", tbxCourse.Text.Trim());
                            cmdStudent.Parameters.AddWithValue("?", yearLevel);  // Ensure integer
                            cmdStudent.Parameters.AddWithValue("?", studentID);  // Ensure integer
                            cmdStudent.ExecuteNonQuery();
                        }
                    }

                    if (Query)
                    {
                        string subjectsQuery = "UPDATE [Student Query] SET LastName = ?, FirstName = ?, " +
                            "CourseNum1 = ?, CourseNum2 = ?, CourseNum3 = ?, CourseNum4 = ?, CourseNum5 = ? " +
                            "WHERE StudentID = ?";

                        using (OleDbCommand cmdSubjects = new OleDbCommand(subjectsQuery, myConn))
                        {
                            cmdSubjects.Parameters.AddWithValue("?", txtBxLastName.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", txtBxFirstName.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", tbxCourse1.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", tbxCourse2.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", tbxCourse3.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", tbxCourse4.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", tbxCourse5.Text.Trim());
                            cmdSubjects.Parameters.AddWithValue("?", studentID);  // Ensure integer
                            cmdSubjects.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void studentTableMenu_Click(object sender, EventArgs e)
        {
            Table = true;
            Query = false;

            panel2.Visible = true;
            panel2.Size = new Size(705, 275);
            lblStudentID.Visible = true;
            lblLastName.Visible = true;
            lblFirstName.Visible = true;
            lblCourse.Visible = true;
            lblYearLevel.Visible = true;

            lblCourse1.Visible = false;
            lblCourse2.Visible = false;
            lblCourse3.Visible = false;
            lblCourse4.Visible = false;
            lblCourse5.Visible = false;

            txtBxStudentID.Visible = true;
            txtBxLastName.Visible = true;
            txtBxFirstName.Visible = true;
            tbxCourse.Visible = true;
            tbxYrLvl.Visible = true;

            tbxCourse1.Visible = false;
            tbxCourse2.Visible = false;
            tbxCourse3.Visible = false;
            tbxCourse4.Visible = false;
            tbxCourse5.Visible = false;

            LoadDataDB();
        }

        private void studentQueryMenu_Click(object sender, EventArgs e)
        {
            Query = true;
            Table = false;

            panel2.Visible = true;
            panel2.Size = new Size(705, 445);
            lblStudentID.Visible = true;
            lblLastName.Visible = true;
            lblFirstName.Visible = true;
            lblCourse.Visible = false;
            lblYearLevel.Visible = false;

            lblCourse1.Visible = true;
            lblCourse2.Visible = true;
            lblCourse3.Visible = true;
            lblCourse4.Visible = true;
            lblCourse5.Visible = true;

            txtBxStudentID.Visible = true;
            txtBxLastName.Visible = true;
            txtBxFirstName.Visible = true;
            tbxCourse.Visible = false;
            tbxYrLvl.Visible = false;

            tbxCourse1.Visible = true;
            tbxCourse2.Visible = true;
            tbxCourse3.Visible = true;
            tbxCourse4.Visible = true;
            tbxCourse5.Visible = true;

            LoadDataDB();
        }

        private void lOADSTUDENTTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table = true;
            Query = false;

            panel2.Visible = true;
            panel2.Size = new Size(705, 275);
            lblStudentID.Visible = true;
            lblLastName.Visible = true;
            lblFirstName.Visible = true;
            lblCourse.Visible = true;
            lblYearLevel.Visible = true;

            lblCourse1.Visible = false;
            lblCourse2.Visible = false;
            lblCourse3.Visible = false;
            lblCourse4.Visible = false;
            lblCourse5.Visible = false;

            txtBxStudentID.Visible = true;
            txtBxLastName.Visible = true;
            txtBxFirstName.Visible = true;
            tbxCourse.Visible = true;
            tbxYrLvl.Visible = true;

            tbxCourse1.Visible = false;
            tbxCourse2.Visible = false;
            tbxCourse3.Visible = false;
            tbxCourse4.Visible = false;
            tbxCourse5.Visible = false;

            LoadDataDB();
        }

        private void lOADSTUDENTQUERYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query = true;
            Table = false;

            panel2.Visible = true;
            panel2.Size = new Size(705, 445);
            lblStudentID.Visible = true;
            lblLastName.Visible = true;
            lblFirstName.Visible = true;
            lblCourse.Visible = false;
            lblYearLevel.Visible = false;

            lblCourse1.Visible = true;
            lblCourse2.Visible = true;
            lblCourse3.Visible = true;
            lblCourse4.Visible = true;
            lblCourse5.Visible = true;

            txtBxStudentID.Visible = true;
            txtBxLastName.Visible = true;
            txtBxFirstName.Visible = true;
            tbxCourse.Visible = false;
            tbxYrLvl.Visible = false;

            tbxCourse1.Visible = true;
            tbxCourse2.Visible = true;
            tbxCourse3.Visible = true;
            tbxCourse4.Visible = true;
            tbxCourse5.Visible = true;

            LoadDataDB();
        }

        private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvStudentInfo.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}