namespace Week_8_Pacres
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConnectionTest = new Button();
            btnLoadData = new Button();
            dgvStudentInfo = new DataGridView();
            lblStudentID = new Label();
            txtBxStudentID = new TextBox();
            txtBxLastName = new TextBox();
            txtBxFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            tbxCourse = new TextBox();
            tbxCourse1 = new TextBox();
            tbxCourse2 = new TextBox();
            tbxCourse3 = new TextBox();
            tbxCourse4 = new TextBox();
            tbxCourse5 = new TextBox();
            lblCourse = new Label();
            lblCourse5 = new Label();
            lblCourse4 = new Label();
            lblCourse3 = new Label();
            lblCourse2 = new Label();
            lblCourse1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolMenuStrip = new ToolStripMenuItem();
            cONNECTIONTESTToolStripMenuItem = new ToolStripMenuItem();
            eDITToolStripMenuItem = new ToolStripMenuItem();
            studentQueryMenu = new ToolStripMenuItem();
            studentTableMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            insertToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            lblYearLevel = new Label();
            tbxYrLvl = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lOADSTUDENTTABLEToolStripMenuItem = new ToolStripMenuItem();
            lOADSTUDENTQUERYToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnectionTest
            // 
            btnConnectionTest.Font = new Font("Century Gothic", 14F);
            btnConnectionTest.Location = new Point(21, 734);
            btnConnectionTest.Margin = new Padding(6, 4, 6, 4);
            btnConnectionTest.Name = "btnConnectionTest";
            btnConnectionTest.Size = new Size(286, 77);
            btnConnectionTest.TabIndex = 0;
            btnConnectionTest.Text = "CONNECTION TEST";
            btnConnectionTest.UseVisualStyleBackColor = true;
            btnConnectionTest.Click += btnConnectionTest_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Font = new Font("Century Gothic", 14F);
            btnLoadData.Location = new Point(316, 734);
            btnLoadData.Margin = new Padding(6, 4, 6, 4);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(246, 77);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "LOAD DATA";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(729, 54);
            dgvStudentInfo.Margin = new Padding(6, 4, 6, 4);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.ReadOnly = true;
            dgvStudentInfo.RowHeadersWidth = 51;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(1116, 761);
            dgvStudentInfo.TabIndex = 2;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            dgvStudentInfo.CellContentClick += dgvStudentInfo_CellContentClick;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Century Gothic", 14F);
            lblStudentID.Location = new Point(9, 24);
            lblStudentID.Margin = new Padding(6, 0, 6, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(143, 30);
            lblStudentID.TabIndex = 3;
            lblStudentID.Text = "STUDENT ID";
            // 
            // txtBxStudentID
            // 
            txtBxStudentID.Font = new Font("Segoe UI", 12F);
            txtBxStudentID.Location = new Point(240, 54);
            txtBxStudentID.Margin = new Padding(6, 4, 6, 4);
            txtBxStudentID.Multiline = true;
            txtBxStudentID.Name = "txtBxStudentID";
            txtBxStudentID.Size = new Size(458, 44);
            txtBxStudentID.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            txtBxLastName.Font = new Font("Segoe UI", 12F);
            txtBxLastName.Location = new Point(240, 106);
            txtBxLastName.Margin = new Padding(6, 4, 6, 4);
            txtBxLastName.Multiline = true;
            txtBxLastName.Name = "txtBxLastName";
            txtBxLastName.Size = new Size(458, 44);
            txtBxLastName.TabIndex = 5;
            // 
            // txtBxFirstName
            // 
            txtBxFirstName.Font = new Font("Segoe UI", 12F);
            txtBxFirstName.Location = new Point(240, 158);
            txtBxFirstName.Margin = new Padding(6, 4, 6, 4);
            txtBxFirstName.Multiline = true;
            txtBxFirstName.Name = "txtBxFirstName";
            txtBxFirstName.Size = new Size(458, 44);
            txtBxFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Century Gothic", 14F);
            lblLastName.Location = new Point(9, 76);
            lblLastName.Margin = new Padding(6, 0, 6, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(142, 30);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "LAST NAME";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Century Gothic", 14F);
            lblFirstName.Location = new Point(9, 128);
            lblFirstName.Margin = new Padding(6, 0, 6, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(147, 30);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "FIRST NAME";
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Century Gothic", 14F);
            btnInsert.Location = new Point(26, 633);
            btnInsert.Margin = new Padding(6, 4, 6, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(208, 66);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Century Gothic", 14F);
            btnDelete.Location = new Point(240, 633);
            btnDelete.Margin = new Padding(6, 4, 6, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(208, 66);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Century Gothic", 14F);
            btnUpdate.Location = new Point(460, 633);
            btnUpdate.Margin = new Padding(6, 4, 6, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(208, 66);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxCourse
            // 
            tbxCourse.Font = new Font("Segoe UI", 12F);
            tbxCourse.Location = new Point(240, 210);
            tbxCourse.Margin = new Padding(6, 4, 6, 4);
            tbxCourse.Multiline = true;
            tbxCourse.Name = "tbxCourse";
            tbxCourse.Size = new Size(458, 44);
            tbxCourse.TabIndex = 12;
            // 
            // tbxCourse1
            // 
            tbxCourse1.Font = new Font("Segoe UI", 12F);
            tbxCourse1.Location = new Point(240, 210);
            tbxCourse1.Margin = new Padding(6, 4, 6, 4);
            tbxCourse1.Multiline = true;
            tbxCourse1.Name = "tbxCourse1";
            tbxCourse1.Size = new Size(458, 44);
            tbxCourse1.TabIndex = 13;
            // 
            // tbxCourse2
            // 
            tbxCourse2.Font = new Font("Segoe UI", 12F);
            tbxCourse2.Location = new Point(240, 262);
            tbxCourse2.Margin = new Padding(6, 4, 6, 4);
            tbxCourse2.Multiline = true;
            tbxCourse2.Name = "tbxCourse2";
            tbxCourse2.Size = new Size(458, 44);
            tbxCourse2.TabIndex = 14;
            // 
            // tbxCourse3
            // 
            tbxCourse3.Font = new Font("Segoe UI", 12F);
            tbxCourse3.Location = new Point(240, 314);
            tbxCourse3.Margin = new Padding(6, 4, 6, 4);
            tbxCourse3.Multiline = true;
            tbxCourse3.Name = "tbxCourse3";
            tbxCourse3.Size = new Size(458, 44);
            tbxCourse3.TabIndex = 15;
            // 
            // tbxCourse4
            // 
            tbxCourse4.Font = new Font("Segoe UI", 12F);
            tbxCourse4.Location = new Point(240, 366);
            tbxCourse4.Margin = new Padding(6, 4, 6, 4);
            tbxCourse4.Multiline = true;
            tbxCourse4.Name = "tbxCourse4";
            tbxCourse4.Size = new Size(458, 44);
            tbxCourse4.TabIndex = 16;
            // 
            // tbxCourse5
            // 
            tbxCourse5.Font = new Font("Segoe UI", 12F);
            tbxCourse5.Location = new Point(240, 418);
            tbxCourse5.Margin = new Padding(6, 4, 6, 4);
            tbxCourse5.Multiline = true;
            tbxCourse5.Name = "tbxCourse5";
            tbxCourse5.Size = new Size(458, 44);
            tbxCourse5.TabIndex = 17;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Century Gothic", 14F);
            lblCourse.Location = new Point(9, 180);
            lblCourse.Margin = new Padding(6, 0, 6, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(110, 30);
            lblCourse.TabIndex = 18;
            lblCourse.Text = "COURSE";
            // 
            // lblCourse5
            // 
            lblCourse5.AutoSize = true;
            lblCourse5.Font = new Font("Century Gothic", 14F);
            lblCourse5.Location = new Point(10, 388);
            lblCourse5.Margin = new Padding(6, 0, 6, 0);
            lblCourse5.Name = "lblCourse5";
            lblCourse5.Size = new Size(130, 30);
            lblCourse5.TabIndex = 19;
            lblCourse5.Text = "COURSE 5";
            // 
            // lblCourse4
            // 
            lblCourse4.AutoSize = true;
            lblCourse4.Font = new Font("Century Gothic", 14F);
            lblCourse4.Location = new Point(9, 336);
            lblCourse4.Margin = new Padding(6, 0, 6, 0);
            lblCourse4.Name = "lblCourse4";
            lblCourse4.Size = new Size(130, 30);
            lblCourse4.TabIndex = 20;
            lblCourse4.Text = "COURSE 4";
            // 
            // lblCourse3
            // 
            lblCourse3.AutoSize = true;
            lblCourse3.Font = new Font("Century Gothic", 14F);
            lblCourse3.Location = new Point(9, 284);
            lblCourse3.Margin = new Padding(6, 0, 6, 0);
            lblCourse3.Name = "lblCourse3";
            lblCourse3.Size = new Size(130, 30);
            lblCourse3.TabIndex = 21;
            lblCourse3.Text = "COURSE 3";
            // 
            // lblCourse2
            // 
            lblCourse2.AutoSize = true;
            lblCourse2.Font = new Font("Century Gothic", 14F);
            lblCourse2.Location = new Point(9, 232);
            lblCourse2.Margin = new Padding(6, 0, 6, 0);
            lblCourse2.Name = "lblCourse2";
            lblCourse2.Size = new Size(130, 30);
            lblCourse2.TabIndex = 22;
            lblCourse2.Text = "COURSE 2";
            // 
            // lblCourse1
            // 
            lblCourse1.AutoSize = true;
            lblCourse1.Font = new Font("Century Gothic", 14F);
            lblCourse1.Location = new Point(9, 180);
            lblCourse1.Margin = new Padding(6, 0, 6, 0);
            lblCourse1.Name = "lblCourse1";
            lblCourse1.Size = new Size(130, 30);
            lblCourse1.TabIndex = 23;
            lblCourse1.Text = "COURSE 1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolMenuStrip, eDITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 2, 0, 2);
            menuStrip1.Size = new Size(1860, 38);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolMenuStrip
            // 
            fileToolMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { cONNECTIONTESTToolStripMenuItem });
            fileToolMenuStrip.Font = new Font("Century Gothic", 14F);
            fileToolMenuStrip.Name = "fileToolMenuStrip";
            fileToolMenuStrip.Size = new Size(69, 34);
            fileToolMenuStrip.Text = "FILE";
            // 
            // cONNECTIONTESTToolStripMenuItem
            // 
            cONNECTIONTESTToolStripMenuItem.Font = new Font("Century Gothic", 14F);
            cONNECTIONTESTToolStripMenuItem.Image = Properties.Resources._2;
            cONNECTIONTESTToolStripMenuItem.Name = "cONNECTIONTESTToolStripMenuItem";
            cONNECTIONTESTToolStripMenuItem.Size = new Size(295, 34);
            cONNECTIONTESTToolStripMenuItem.Text = "Connection Test";
            cONNECTIONTESTToolStripMenuItem.Click += cONNECTIONTESTToolStripMenuItem_Click;
            // 
            // eDITToolStripMenuItem
            // 
            eDITToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentQueryMenu, studentTableMenu, toolStripSeparator1, insertToolStripMenuItem, deleteToolStripMenuItem1, updateToolStripMenuItem1 });
            eDITToolStripMenuItem.Font = new Font("Century Gothic", 14F);
            eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            eDITToolStripMenuItem.Size = new Size(75, 34);
            eDITToolStripMenuItem.Text = "EDIT";
            // 
            // studentQueryMenu
            // 
            studentQueryMenu.Image = Properties.Resources._4;
            studentQueryMenu.Name = "studentQueryMenu";
            studentQueryMenu.Size = new Size(269, 34);
            studentQueryMenu.Text = "Student Query";
            studentQueryMenu.Click += studentQueryMenu_Click;
            // 
            // studentTableMenu
            // 
            studentTableMenu.Image = Properties.Resources._5;
            studentTableMenu.Name = "studentTableMenu";
            studentTableMenu.Size = new Size(269, 34);
            studentTableMenu.Text = "Student Table";
            studentTableMenu.Click += studentTableMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(266, 6);
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Image = Properties.Resources._6;
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(269, 34);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources._7;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(269, 34);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Image = Properties.Resources._8;
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(269, 34);
            updateToolStripMenuItem1.Text = "Update";
            updateToolStripMenuItem1.Click += updateToolStripMenuItem1_Click;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.Font = new Font("Century Gothic", 14F);
            lblYearLevel.Location = new Point(10, 232);
            lblYearLevel.Margin = new Padding(6, 0, 6, 0);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(146, 30);
            lblYearLevel.TabIndex = 26;
            lblYearLevel.Text = "YEAR LEVEL";
            // 
            // tbxYrLvl
            // 
            tbxYrLvl.Font = new Font("Segoe UI", 12F);
            tbxYrLvl.Location = new Point(240, 262);
            tbxYrLvl.Margin = new Padding(6, 4, 6, 4);
            tbxYrLvl.Multiline = true;
            tbxYrLvl.Name = "tbxYrLvl";
            tbxYrLvl.Size = new Size(458, 44);
            tbxYrLvl.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cit_logo;
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(708, 775);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 828);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(lblStudentID);
            panel2.Controls.Add(lblLastName);
            panel2.Controls.Add(lblCourse5);
            panel2.Controls.Add(lblCourse4);
            panel2.Controls.Add(lblCourse3);
            panel2.Controls.Add(lblCourse2);
            panel2.Controls.Add(lblCourse1);
            panel2.Controls.Add(lblFirstName);
            panel2.Controls.Add(lblCourse);
            panel2.Controls.Add(lblYearLevel);
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(12, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 445);
            panel2.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Century Gothic", 14F);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { lOADSTUDENTTABLEToolStripMenuItem, lOADSTUDENTQUERYToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(260, 72);
            // 
            // lOADSTUDENTTABLEToolStripMenuItem
            // 
            lOADSTUDENTTABLEToolStripMenuItem.Image = Properties.Resources._4;
            lOADSTUDENTTABLEToolStripMenuItem.Name = "lOADSTUDENTTABLEToolStripMenuItem";
            lOADSTUDENTTABLEToolStripMenuItem.Size = new Size(259, 34);
            lOADSTUDENTTABLEToolStripMenuItem.Text = "Student Table";
            lOADSTUDENTTABLEToolStripMenuItem.Click += lOADSTUDENTTABLEToolStripMenuItem_Click;
            // 
            // lOADSTUDENTQUERYToolStripMenuItem
            // 
            lOADSTUDENTQUERYToolStripMenuItem.Image = Properties.Resources._5;
            lOADSTUDENTQUERYToolStripMenuItem.Name = "lOADSTUDENTQUERYToolStripMenuItem";
            lOADSTUDENTQUERYToolStripMenuItem.Size = new Size(259, 34);
            lOADSTUDENTQUERYToolStripMenuItem.Text = "Student Query";
            lOADSTUDENTQUERYToolStripMenuItem.Click += lOADSTUDENTQUERYToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1860, 828);
            Controls.Add(tbxYrLvl);
            Controls.Add(tbxCourse5);
            Controls.Add(tbxCourse4);
            Controls.Add(tbxCourse3);
            Controls.Add(tbxCourse2);
            Controls.Add(tbxCourse1);
            Controls.Add(tbxCourse);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtBxFirstName);
            Controls.Add(txtBxLastName);
            Controls.Add(txtBxStudentID);
            Controls.Add(dgvStudentInfo);
            Controls.Add(btnLoadData);
            Controls.Add(btnConnectionTest);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Database Editor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnectionTest;
        private Button btnLoadData;
        private DataGridView dgvStudentInfo;
        private Label lblStudentID;
        private TextBox txtBxStudentID;
        private TextBox txtBxLastName;
        private TextBox txtBxFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox tbxCourse;
        private TextBox tbxCourse1;
        private TextBox tbxCourse2;
        private TextBox tbxCourse3;
        private TextBox tbxCourse4;
        private TextBox tbxCourse5;
        private Label lblCourse;
        private Label lblCourse5;
        private Label lblCourse4;
        private Label lblCourse3;
        private Label lblCourse2;
        private Label lblCourse1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolMenuStrip;
        private ToolStripMenuItem cONNECTIONTESTToolStripMenuItem;
        private ToolStripMenuItem eDITToolStripMenuItem;
        private ToolStripMenuItem studentTableMenu;
        private ToolStripMenuItem studentQueryMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private Label lblYearLevel;
        private TextBox tbxYrLvl;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem lOADSTUDENTTABLEToolStripMenuItem;
        private ToolStripMenuItem lOADSTUDENTQUERYToolStripMenuItem;
        private Panel panel2;
    }
}
