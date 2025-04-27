namespace Pacres_Week_6_Assignment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            studentIDColumn = new DataGridViewTextBoxColumn();
            firstNameColumn = new DataGridViewTextBoxColumn();
            middleInitialColumn = new DataGridViewTextBoxColumn();
            lastNameColumn = new DataGridViewTextBoxColumn();
            sexColumn = new DataGridViewTextBoxColumn();
            dateOfBirthColumn = new DataGridViewTextBoxColumn();
            addressColumn = new DataGridViewTextBoxColumn();
            collegeColumn = new DataGridViewTextBoxColumn();
            studentID = new Label();
            firstName = new Label();
            lastName = new Label();
            address = new Label();
            college = new Label();
            menuStrip1 = new MenuStrip();
            FileMenuStrip = new ToolStripMenuItem();
            importDataToolMenuStrip = new ToolStripMenuItem();
            exportToolMenuStrip = new ToolStripMenuItem();
            exitMenuStrip = new ToolStripMenuItem();
            eDITToolStripMenuItem = new ToolStripMenuItem();
            deleteToolMenuStrip = new ToolStripMenuItem();
            resetToolMenuStrip = new ToolStripMenuItem();
            sORTToolStripMenuItem = new ToolStripMenuItem();
            bYFIRSTNAMEToolStripMenuItem = new ToolStripMenuItem();
            bYFIRSTNAMEToolStripMenuItem1 = new ToolStripMenuItem();
            aSCENDINGToolStripMenuItem = new ToolStripMenuItem();
            dESCENDINGToolStripMenuItem = new ToolStripMenuItem();
            bYLASTNAMEToolStripMenuItem1 = new ToolStripMenuItem();
            aSCENDINGToolStripMenuItem1 = new ToolStripMenuItem();
            dESCENDINGToolStripMenuItem1 = new ToolStripMenuItem();
            bYLASTNAMEToolStripMenuItem = new ToolStripMenuItem();
            aSCENDINGToolStripMenuItem2 = new ToolStripMenuItem();
            dESCENDINGToolStripMenuItem2 = new ToolStripMenuItem();
            txtStudentID = new TextBox();
            txtMiddleInitial = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            middleInitial = new Label();
            sex = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            pnsRadioButton = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            addNew = new Button();
            resetBtn = new Button();
            delete = new Button();
            save = new Button();
            dateOfBirthLabel = new Label();
            exit = new Button();
            txtAddress = new TextBox();
            txtCollege = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            gradient1 = new Gradient();
            deleteColumn = new Button();
            addColumn = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            gradient1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentIDColumn, firstNameColumn, middleInitialColumn, lastNameColumn, sexColumn, dateOfBirthColumn, addressColumn, collegeColumn });
            dataGridView1.Location = new Point(14, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 433);
            dataGridView1.TabIndex = 0;
            // 
            // studentIDColumn
            // 
            studentIDColumn.HeaderText = "Student ID";
            studentIDColumn.MinimumWidth = 6;
            studentIDColumn.Name = "studentIDColumn";
            studentIDColumn.Width = 125;
            // 
            // firstNameColumn
            // 
            firstNameColumn.HeaderText = "First Name";
            firstNameColumn.MinimumWidth = 6;
            firstNameColumn.Name = "firstNameColumn";
            firstNameColumn.Width = 130;
            // 
            // middleInitialColumn
            // 
            middleInitialColumn.HeaderText = "MI";
            middleInitialColumn.MinimumWidth = 6;
            middleInitialColumn.Name = "middleInitialColumn";
            middleInitialColumn.Width = 50;
            // 
            // lastNameColumn
            // 
            lastNameColumn.HeaderText = "Last Name";
            lastNameColumn.MinimumWidth = 6;
            lastNameColumn.Name = "lastNameColumn";
            lastNameColumn.Width = 130;
            // 
            // sexColumn
            // 
            sexColumn.HeaderText = "Sex";
            sexColumn.MinimumWidth = 6;
            sexColumn.Name = "sexColumn";
            sexColumn.Width = 125;
            // 
            // dateOfBirthColumn
            // 
            dateOfBirthColumn.HeaderText = "Date of Birth";
            dateOfBirthColumn.MinimumWidth = 6;
            dateOfBirthColumn.Name = "dateOfBirthColumn";
            dateOfBirthColumn.Width = 125;
            // 
            // addressColumn
            // 
            addressColumn.HeaderText = "Address";
            addressColumn.MinimumWidth = 6;
            addressColumn.Name = "addressColumn";
            addressColumn.Width = 125;
            // 
            // collegeColumn
            // 
            collegeColumn.HeaderText = "College";
            collegeColumn.MinimumWidth = 6;
            collegeColumn.Name = "collegeColumn";
            collegeColumn.Width = 125;
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(11, 9);
            studentID.Name = "studentID";
            studentID.Size = new Size(113, 26);
            studentID.TabIndex = 1;
            studentID.Text = "Student ID";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Font = new Font("Times New Roman", 13.8F);
            firstName.Location = new Point(10, 42);
            firstName.Name = "firstName";
            firstName.Size = new Size(114, 26);
            firstName.TabIndex = 2;
            firstName.Text = "First Name";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Font = new Font("Times New Roman", 13.8F);
            lastName.Location = new Point(11, 104);
            lastName.Name = "lastName";
            lastName.Size = new Size(110, 26);
            lastName.TabIndex = 3;
            lastName.Text = "Last Name";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Times New Roman", 13.8F);
            address.Location = new Point(45, 33);
            address.Name = "address";
            address.Size = new Size(88, 26);
            address.TabIndex = 4;
            address.Text = "Address";
            // 
            // college
            // 
            college.AutoSize = true;
            college.Font = new Font("Times New Roman", 13.8F);
            college.Location = new Point(51, 66);
            college.Name = "college";
            college.Size = new Size(82, 26);
            college.TabIndex = 6;
            college.Text = "College";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Lime;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMenuStrip, eDITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 34);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            FileMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { importDataToolMenuStrip, exportToolMenuStrip, exitMenuStrip });
            FileMenuStrip.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileMenuStrip.Name = "FileMenuStrip";
            FileMenuStrip.Size = new Size(73, 30);
            FileMenuStrip.Text = "FILE";
            // 
            // importDataToolMenuStrip
            // 
            importDataToolMenuStrip.Name = "importDataToolMenuStrip";
            importDataToolMenuStrip.Size = new Size(266, 30);
            importDataToolMenuStrip.Text = "IMPORT DATA";
            importDataToolMenuStrip.Click += importDataToolMenuStrip_Click;
            // 
            // exportToolMenuStrip
            // 
            exportToolMenuStrip.Name = "exportToolMenuStrip";
            exportToolMenuStrip.Size = new Size(266, 30);
            exportToolMenuStrip.Text = "EXPORT DATA";
            exportToolMenuStrip.Click += exportToolMenuStrip_Click;
            // 
            // exitMenuStrip
            // 
            exitMenuStrip.Name = "exitMenuStrip";
            exitMenuStrip.Size = new Size(266, 30);
            exitMenuStrip.Text = "EXIT PROGRAM";
            exitMenuStrip.Click += eXITPROGRAMToolStripMenuItem1_Click;
            // 
            // eDITToolStripMenuItem
            // 
            eDITToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteToolMenuStrip, resetToolMenuStrip });
            eDITToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            eDITToolStripMenuItem.Size = new Size(77, 30);
            eDITToolStripMenuItem.Text = "EDIT";
            // 
            // deleteToolMenuStrip
            // 
            deleteToolMenuStrip.Name = "deleteToolMenuStrip";
            deleteToolMenuStrip.Size = new Size(180, 30);
            deleteToolMenuStrip.Text = "DELETE";
            deleteToolMenuStrip.Click += deleteToolMenuStrip_Click;
            // 
            // resetToolMenuStrip
            // 
            resetToolMenuStrip.Name = "resetToolMenuStrip";
            resetToolMenuStrip.Size = new Size(180, 30);
            resetToolMenuStrip.Text = "RESET";
            resetToolMenuStrip.Click += resetToolMenuStrip_Click;
            // 
            // sORTToolStripMenuItem
            // 
            sORTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bYFIRSTNAMEToolStripMenuItem, bYLASTNAMEToolStripMenuItem });
            sORTToolStripMenuItem.Name = "sORTToolStripMenuItem";
            sORTToolStripMenuItem.Size = new Size(224, 30);
            sORTToolStripMenuItem.Text = "SORT";
            // 
            // bYFIRSTNAMEToolStripMenuItem
            // 
            bYFIRSTNAMEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bYFIRSTNAMEToolStripMenuItem1, bYLASTNAMEToolStripMenuItem1 });
            bYFIRSTNAMEToolStripMenuItem.Name = "bYFIRSTNAMEToolStripMenuItem";
            bYFIRSTNAMEToolStripMenuItem.Size = new Size(173, 26);
            bYFIRSTNAMEToolStripMenuItem.Text = "BY NAME";
            // 
            // bYFIRSTNAMEToolStripMenuItem1
            // 
            bYFIRSTNAMEToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aSCENDINGToolStripMenuItem, dESCENDINGToolStripMenuItem });
            bYFIRSTNAMEToolStripMenuItem1.Name = "bYFIRSTNAMEToolStripMenuItem1";
            bYFIRSTNAMEToolStripMenuItem1.Size = new Size(195, 26);
            bYFIRSTNAMEToolStripMenuItem1.Text = "BY FIRST NAME";
            // 
            // aSCENDINGToolStripMenuItem
            // 
            aSCENDINGToolStripMenuItem.Name = "aSCENDINGToolStripMenuItem";
            aSCENDINGToolStripMenuItem.Size = new Size(183, 26);
            aSCENDINGToolStripMenuItem.Text = "ASCENDING";
            // 
            // dESCENDINGToolStripMenuItem
            // 
            dESCENDINGToolStripMenuItem.Name = "dESCENDINGToolStripMenuItem";
            dESCENDINGToolStripMenuItem.Size = new Size(183, 26);
            dESCENDINGToolStripMenuItem.Text = "DESCENDING";
            // 
            // bYLASTNAMEToolStripMenuItem1
            // 
            bYLASTNAMEToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aSCENDINGToolStripMenuItem1, dESCENDINGToolStripMenuItem1 });
            bYLASTNAMEToolStripMenuItem1.Name = "bYLASTNAMEToolStripMenuItem1";
            bYLASTNAMEToolStripMenuItem1.Size = new Size(195, 26);
            bYLASTNAMEToolStripMenuItem1.Text = "BY LAST NAME";
            // 
            // aSCENDINGToolStripMenuItem1
            // 
            aSCENDINGToolStripMenuItem1.Name = "aSCENDINGToolStripMenuItem1";
            aSCENDINGToolStripMenuItem1.Size = new Size(183, 26);
            aSCENDINGToolStripMenuItem1.Text = "ASCENDING";
            // 
            // dESCENDINGToolStripMenuItem1
            // 
            dESCENDINGToolStripMenuItem1.Name = "dESCENDINGToolStripMenuItem1";
            dESCENDINGToolStripMenuItem1.Size = new Size(183, 26);
            dESCENDINGToolStripMenuItem1.Text = "DESCENDING";
            // 
            // bYLASTNAMEToolStripMenuItem
            // 
            bYLASTNAMEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aSCENDINGToolStripMenuItem2, dESCENDINGToolStripMenuItem2 });
            bYLASTNAMEToolStripMenuItem.Name = "bYLASTNAMEToolStripMenuItem";
            bYLASTNAMEToolStripMenuItem.Size = new Size(173, 26);
            bYLASTNAMEToolStripMenuItem.Text = "BY COLLEGE";
            // 
            // aSCENDINGToolStripMenuItem2
            // 
            aSCENDINGToolStripMenuItem2.Name = "aSCENDINGToolStripMenuItem2";
            aSCENDINGToolStripMenuItem2.Size = new Size(183, 26);
            aSCENDINGToolStripMenuItem2.Text = "ASCENDING";
            // 
            // dESCENDINGToolStripMenuItem2
            // 
            dESCENDINGToolStripMenuItem2.Name = "dESCENDINGToolStripMenuItem2";
            dESCENDINGToolStripMenuItem2.Size = new Size(183, 26);
            dESCENDINGToolStripMenuItem2.Text = "DESCENDING";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(159, 77);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(246, 27);
            txtStudentID.TabIndex = 0;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(159, 143);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(246, 27);
            txtMiddleInitial.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(159, 110);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(246, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(159, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(246, 27);
            txtLastName.TabIndex = 3;
            // 
            // middleInitial
            // 
            middleInitial.AutoSize = true;
            middleInitial.Font = new Font("Times New Roman", 13.8F);
            middleInitial.Location = new Point(14, 73);
            middleInitial.Name = "middleInitial";
            middleInitial.Size = new Size(51, 26);
            middleInitial.TabIndex = 16;
            middleInitial.Text = "M.I.";
            // 
            // sex
            // 
            sex.AutoSize = true;
            sex.Font = new Font("Times New Roman", 13.8F);
            sex.Location = new Point(10, 141);
            sex.Name = "sex";
            sex.Size = new Size(46, 26);
            sex.TabIndex = 17;
            sex.Text = "Sex";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Times New Roman", 13.8F);
            maleRadioButton.Location = new Point(145, 137);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(78, 30);
            maleRadioButton.TabIndex = 18;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Times New Roman", 13.8F);
            femaleRadioButton.Location = new Point(145, 167);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(100, 30);
            femaleRadioButton.TabIndex = 19;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // pnsRadioButton
            // 
            pnsRadioButton.AutoSize = true;
            pnsRadioButton.Font = new Font("Times New Roman", 13.8F);
            pnsRadioButton.Location = new Point(145, 197);
            pnsRadioButton.Name = "pnsRadioButton";
            pnsRadioButton.Size = new Size(186, 30);
            pnsRadioButton.TabIndex = 20;
            pnsRadioButton.TabStop = true;
            pnsRadioButton.Text = "Prefer not to say";
            pnsRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(597, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // addNew
            // 
            addNew.Font = new Font("Times New Roman", 13.8F);
            addNew.Location = new Point(736, 351);
            addNew.Name = "addNew";
            addNew.Size = new Size(234, 60);
            addNew.TabIndex = 6;
            addNew.Text = "Add Row";
            addNew.UseVisualStyleBackColor = true;
            addNew.Click += addNew_Click;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Times New Roman", 13.8F);
            resetBtn.Location = new Point(736, 549);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(234, 60);
            resetBtn.TabIndex = 26;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Times New Roman", 13.8F);
            delete.Location = new Point(736, 483);
            delete.Name = "delete";
            delete.Size = new Size(234, 60);
            delete.TabIndex = 28;
            delete.Text = "Delete Row";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // save
            // 
            save.Font = new Font("Times New Roman", 13.8F);
            save.Location = new Point(736, 615);
            save.Name = "save";
            save.Size = new Size(234, 60);
            save.TabIndex = 29;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Times New Roman", 13.8F);
            dateOfBirthLabel.Location = new Point(45, 2);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(132, 26);
            dateOfBirthLabel.TabIndex = 30;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // exit
            // 
            exit.Font = new Font("Times New Roman", 13.8F);
            exit.Location = new Point(736, 681);
            exit.Name = "exit";
            exit.Size = new Size(234, 60);
            exit.TabIndex = 31;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(597, 110);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(247, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtCollege
            // 
            txtCollege.Location = new Point(596, 145);
            txtCollege.Name = "txtCollege";
            txtCollege.Size = new Size(247, 27);
            txtCollege.TabIndex = 6;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // gradient1
            // 
            gradient1.Angle = 0F;
            gradient1.BackColor = Color.DarkGreen;
            gradient1.BottomColor = Color.Empty;
            gradient1.Controls.Add(deleteColumn);
            gradient1.Controls.Add(addColumn);
            gradient1.Controls.Add(panel2);
            gradient1.Controls.Add(exit);
            gradient1.Controls.Add(save);
            gradient1.Controls.Add(panel1);
            gradient1.Controls.Add(delete);
            gradient1.Controls.Add(addNew);
            gradient1.Controls.Add(dataGridView1);
            gradient1.Controls.Add(resetBtn);
            gradient1.Dock = DockStyle.Fill;
            gradient1.Location = new Point(0, 0);
            gradient1.Name = "gradient1";
            gradient1.Size = new Size(982, 753);
            gradient1.TabIndex = 34;
            gradient1.TopColor = Color.Lime;
            // 
            // deleteColumn
            // 
            deleteColumn.Font = new Font("Times New Roman", 13.8F);
            deleteColumn.Location = new Point(736, 417);
            deleteColumn.Name = "deleteColumn";
            deleteColumn.Size = new Size(234, 60);
            deleteColumn.TabIndex = 37;
            deleteColumn.Text = "Delete Column";
            deleteColumn.UseVisualStyleBackColor = true;
            deleteColumn.Click += deleteColumn_Click;
            // 
            // addColumn
            // 
            addColumn.Font = new Font("Times New Roman", 13.8F);
            addColumn.Location = new Point(736, 285);
            addColumn.Name = "addColumn";
            addColumn.Size = new Size(234, 60);
            addColumn.TabIndex = 36;
            addColumn.Text = "Add Column";
            addColumn.UseVisualStyleBackColor = true;
            addColumn.Click += addColumn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(dateOfBirthLabel);
            panel2.Controls.Add(address);
            panel2.Controls.Add(college);
            panel2.Location = new Point(411, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 125);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(firstName);
            panel1.Controls.Add(lastName);
            panel1.Controls.Add(maleRadioButton);
            panel1.Controls.Add(femaleRadioButton);
            panel1.Controls.Add(sex);
            panel1.Controls.Add(pnsRadioButton);
            panel1.Controls.Add(middleInitial);
            panel1.Controls.Add(studentID);
            panel1.Location = new Point(14, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 231);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(txtCollege);
            Controls.Add(txtAddress);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtStudentID);
            Controls.Add(menuStrip1);
            Controls.Add(gradient1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Student Data Manager";
            ResizeEnd += OnResizeEnd;
            Resize += OnResize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gradient1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label studentID;
        private Label firstName;
        private Label lastName;
        private Label address;
        private Label label5;
        private Label college;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenuStrip;
        private ToolStripMenuItem importDataToolMenuStrip;
        private ToolStripMenuItem oPENEXCELToolStripMenuItem;
        private ToolStripMenuItem exportToolMenuStrip;
        private TextBox txtStudentID;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox txtMiddleInitial;
        private TextBox txtFirstName;
        private TextBox textBox7;
        private TextBox txtLastName;
        private Label middleInitial;
        private Label sex;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private RadioButton pnsRadioButton;
        private DateTimePicker dateTimePicker1;
        private Button addNew;
        private Button resetBtn;
        private Button delete;
        private Button save;
        private Label dateOfBirthLabel;
        private ToolStripMenuItem eDITToolStripMenuItem;
        private ToolStripMenuItem rESETToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ToolStripMenuItem sORTToolStripMenuItem;
        private ToolStripMenuItem bYFIRSTNAMEToolStripMenuItem;
        private ToolStripMenuItem bYFIRSTNAMEToolStripMenuItem1;
        private ToolStripMenuItem aSCENDINGToolStripMenuItem;
        private ToolStripMenuItem dESCENDINGToolStripMenuItem;
        private ToolStripMenuItem bYLASTNAMEToolStripMenuItem1;
        private ToolStripMenuItem aSCENDINGToolStripMenuItem1;
        private ToolStripMenuItem dESCENDINGToolStripMenuItem1;
        private ToolStripMenuItem bYLASTNAMEToolStripMenuItem;
        private ToolStripMenuItem aSCENDINGToolStripMenuItem2;
        private ToolStripMenuItem dESCENDINGToolStripMenuItem2;
        private Button exit;
        private ToolStripMenuItem exitMenuStrip;
        private DataGridViewTextBoxColumn studentIDColumn;
        private DataGridViewTextBoxColumn firstNameColumn;
        private DataGridViewTextBoxColumn middleInitialColumn;
        private DataGridViewTextBoxColumn lastNameColumn;
        private DataGridViewTextBoxColumn sexColumn;
        private DataGridViewTextBoxColumn dateOfBirthColumn;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn collegeColumn;
        private TextBox txtAddress;
        private TextBox txtCollege;
        private ToolStripMenuItem deleteToolMenuStrip;
        private ToolStripMenuItem resetToolMenuStrip;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Gradient gradient1;
        private Panel panel1;
        private Panel panel2;
        private Button addColumn;
        private Button deleteColumn;
    }
}
