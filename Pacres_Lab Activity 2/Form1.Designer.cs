namespace Pacres_Lab_Activity_2
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
            userDetails = new GroupBox();
            addressTxtBx = new TextBox();
            courseTxtBx = new TextBox();
            nameTxtBx = new TextBox();
            addressLabel = new Label();
            courseLabel = new Label();
            nameLabel = new Label();
            listBox1 = new ListBox();
            maleRBtn = new RadioButton();
            femaleRBtn = new RadioButton();
            C_cBox = new CheckBox();
            Cplus2_cBox = new CheckBox();
            Csharp_cBox = new CheckBox();
            java_cBox = new CheckBox();
            python_cBox = new CheckBox();
            javaScript_cBox = new CheckBox();
            rust_cBox = new CheckBox();
            assembly_cBox = new CheckBox();
            html_cBox = new CheckBox();
            swift_cBox = new CheckBox();
            preferNotToSay = new RadioButton();
            php_cBox = new CheckBox();
            esoLang_cBox = new CheckBox();
            btnSubmit = new Button();
            btnExit = new Button();
            userDetails.SuspendLayout();
            SuspendLayout();
            // 
            // userDetails
            // 
            userDetails.Controls.Add(addressTxtBx);
            userDetails.Controls.Add(courseTxtBx);
            userDetails.Controls.Add(nameTxtBx);
            userDetails.Controls.Add(addressLabel);
            userDetails.Controls.Add(courseLabel);
            userDetails.Controls.Add(nameLabel);
            userDetails.Location = new Point(12, 12);
            userDetails.Name = "userDetails";
            userDetails.Size = new Size(287, 173);
            userDetails.TabIndex = 0;
            userDetails.TabStop = false;
            userDetails.Text = "User Details";
            // 
            // addressTxtBx
            // 
            addressTxtBx.Location = new Point(74, 103);
            addressTxtBx.Name = "addressTxtBx";
            addressTxtBx.Size = new Size(178, 23);
            addressTxtBx.TabIndex = 5;
            // 
            // courseTxtBx
            // 
            courseTxtBx.Location = new Point(74, 67);
            courseTxtBx.Name = "courseTxtBx";
            courseTxtBx.Size = new Size(178, 23);
            courseTxtBx.TabIndex = 4;
            // 
            // nameTxtBx
            // 
            nameTxtBx.Location = new Point(74, 28);
            nameTxtBx.Name = "nameTxtBx";
            nameTxtBx.Size = new Size(178, 23);
            nameTxtBx.TabIndex = 3;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 103);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new Point(12, 67);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(47, 15);
            courseLabel.TabIndex = 1;
            courseLabel.Text = "Course:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "BSCE", "BSChE", "BSME", "BSCpE", "BSEE", "BSECE", "BSIE", "BSCS", "BSIT", "BSPsych", "BSBio" });
            listBox1.Location = new Point(12, 191);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(287, 139);
            listBox1.TabIndex = 1;
            // 
            // maleRBtn
            // 
            maleRBtn.AutoSize = true;
            maleRBtn.Location = new Point(349, 50);
            maleRBtn.Name = "maleRBtn";
            maleRBtn.Size = new Size(51, 19);
            maleRBtn.TabIndex = 6;
            maleRBtn.TabStop = true;
            maleRBtn.Text = "Male";
            maleRBtn.UseVisualStyleBackColor = true;
            maleRBtn.CheckedChanged += maleRBtn_CheckedChanged;
            // 
            // femaleRBtn
            // 
            femaleRBtn.AutoSize = true;
            femaleRBtn.Location = new Point(349, 75);
            femaleRBtn.Name = "femaleRBtn";
            femaleRBtn.Size = new Size(63, 19);
            femaleRBtn.TabIndex = 7;
            femaleRBtn.TabStop = true;
            femaleRBtn.Text = "Female";
            femaleRBtn.UseVisualStyleBackColor = true;
            femaleRBtn.CheckedChanged += femaleRBtn_CheckedChanged;
            // 
            // C_cBox
            // 
            C_cBox.AutoSize = true;
            C_cBox.Location = new Point(317, 191);
            C_cBox.Name = "C_cBox";
            C_cBox.Size = new Size(34, 19);
            C_cBox.TabIndex = 8;
            C_cBox.Text = "C";
            C_cBox.UseVisualStyleBackColor = true;
            // 
            // Cplus2_cBox
            // 
            Cplus2_cBox.AutoSize = true;
            Cplus2_cBox.Location = new Point(317, 216);
            Cplus2_cBox.Name = "Cplus2_cBox";
            Cplus2_cBox.Size = new Size(50, 19);
            Cplus2_cBox.TabIndex = 9;
            Cplus2_cBox.Text = "C++";
            Cplus2_cBox.UseVisualStyleBackColor = true;
            // 
            // Csharp_cBox
            // 
            Csharp_cBox.AutoSize = true;
            Csharp_cBox.Location = new Point(317, 241);
            Csharp_cBox.Name = "Csharp_cBox";
            Csharp_cBox.Size = new Size(41, 19);
            Csharp_cBox.TabIndex = 10;
            Csharp_cBox.Text = "C#";
            Csharp_cBox.UseVisualStyleBackColor = true;
            // 
            // java_cBox
            // 
            java_cBox.AutoSize = true;
            java_cBox.Location = new Point(317, 266);
            java_cBox.Name = "java_cBox";
            java_cBox.Size = new Size(48, 19);
            java_cBox.TabIndex = 11;
            java_cBox.Text = "Java";
            java_cBox.UseVisualStyleBackColor = true;
            // 
            // python_cBox
            // 
            python_cBox.AutoSize = true;
            python_cBox.Location = new Point(317, 291);
            python_cBox.Name = "python_cBox";
            python_cBox.Size = new Size(64, 19);
            python_cBox.TabIndex = 12;
            python_cBox.Text = "Python";
            python_cBox.UseVisualStyleBackColor = true;
            // 
            // javaScript_cBox
            // 
            javaScript_cBox.AutoSize = true;
            javaScript_cBox.Location = new Point(317, 316);
            javaScript_cBox.Name = "javaScript_cBox";
            javaScript_cBox.Size = new Size(78, 19);
            javaScript_cBox.TabIndex = 13;
            javaScript_cBox.Text = "JavaScript";
            javaScript_cBox.UseVisualStyleBackColor = true;
            // 
            // rust_cBox
            // 
            rust_cBox.AutoSize = true;
            rust_cBox.Location = new Point(424, 191);
            rust_cBox.Name = "rust_cBox";
            rust_cBox.Size = new Size(49, 19);
            rust_cBox.TabIndex = 14;
            rust_cBox.Text = "Rust";
            rust_cBox.UseVisualStyleBackColor = true;
            // 
            // assembly_cBox
            // 
            assembly_cBox.AutoSize = true;
            assembly_cBox.Location = new Point(424, 216);
            assembly_cBox.Name = "assembly_cBox";
            assembly_cBox.Size = new Size(77, 19);
            assembly_cBox.TabIndex = 15;
            assembly_cBox.Text = "Assembly";
            assembly_cBox.UseVisualStyleBackColor = true;
            // 
            // html_cBox
            // 
            html_cBox.AutoSize = true;
            html_cBox.Location = new Point(424, 241);
            html_cBox.Name = "html_cBox";
            html_cBox.Size = new Size(58, 19);
            html_cBox.TabIndex = 16;
            html_cBox.Text = "HTML";
            html_cBox.UseVisualStyleBackColor = true;
            // 
            // swift_cBox
            // 
            swift_cBox.AutoSize = true;
            swift_cBox.Location = new Point(424, 266);
            swift_cBox.Name = "swift_cBox";
            swift_cBox.Size = new Size(52, 19);
            swift_cBox.TabIndex = 17;
            swift_cBox.Text = "Swift";
            swift_cBox.UseVisualStyleBackColor = true;
            // 
            // preferNotToSay
            // 
            preferNotToSay.AutoSize = true;
            preferNotToSay.Location = new Point(349, 100);
            preferNotToSay.Name = "preferNotToSay";
            preferNotToSay.Size = new Size(111, 19);
            preferNotToSay.TabIndex = 18;
            preferNotToSay.TabStop = true;
            preferNotToSay.Text = "Prefer not to say";
            preferNotToSay.UseVisualStyleBackColor = true;
            // 
            // php_cBox
            // 
            php_cBox.AutoSize = true;
            php_cBox.Location = new Point(424, 291);
            php_cBox.Name = "php_cBox";
            php_cBox.Size = new Size(49, 19);
            php_cBox.TabIndex = 19;
            php_cBox.Text = "PHP";
            php_cBox.UseVisualStyleBackColor = true;
            // 
            // esoLang_cBox
            // 
            esoLang_cBox.AutoSize = true;
            esoLang_cBox.Location = new Point(424, 316);
            esoLang_cBox.Name = "esoLang_cBox";
            esoLang_cBox.Size = new Size(67, 19);
            esoLang_cBox.TabIndex = 20;
            esoLang_cBox.Text = "Esolang";
            esoLang_cBox.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(189, 381);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(349, 381);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 426);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(esoLang_cBox);
            Controls.Add(php_cBox);
            Controls.Add(preferNotToSay);
            Controls.Add(swift_cBox);
            Controls.Add(html_cBox);
            Controls.Add(assembly_cBox);
            Controls.Add(rust_cBox);
            Controls.Add(javaScript_cBox);
            Controls.Add(python_cBox);
            Controls.Add(java_cBox);
            Controls.Add(Csharp_cBox);
            Controls.Add(Cplus2_cBox);
            Controls.Add(C_cBox);
            Controls.Add(femaleRBtn);
            Controls.Add(maleRBtn);
            Controls.Add(listBox1);
            Controls.Add(userDetails);
            Name = "Form1";
            Text = "Form1";
            userDetails.ResumeLayout(false);
            userDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox userDetails;
        private TextBox addressTxtBx;
        private TextBox courseTxtBx;
        private TextBox nameTxtBx;
        private Label addressLabel;
        private Label courseLabel;
        private Label nameLabel;
        private ListBox listBox1;
        private RadioButton maleRBtn;
        private RadioButton femaleRBtn;
        private CheckBox C_cBox;
        private CheckBox Cplus2_cBox;
        private CheckBox Csharp_cBox;
        private CheckBox java_cBox;
        private CheckBox python_cBox;
        private CheckBox javaScript_cBox;
        private CheckBox rust_cBox;
        private CheckBox assembly_cBox;
        private CheckBox html_cBox;
        private CheckBox swift_cBox;
        private RadioButton preferNotToSay;
        private CheckBox php_cBox;
        private CheckBox esoLang_cBox;
        private Button btnSubmit;
        private Button btnExit;
    }
}
