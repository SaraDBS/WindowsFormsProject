namespace CAStudentManagementSystem
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.comboCourses = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.radioPost = new System.Windows.Forms.RadioButton();
            this.radioUnder = new System.Windows.Forms.RadioButton();
            this.lblCourseLevel = new System.Windows.Forms.Label();
            this.comboBoxCounties = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAdrline2 = new System.Windows.Forms.TextBox();
            this.txtAdrline1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAdrline2 = new System.Windows.Forms.Label();
            this.lblAdrline1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxAdd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.txtPhone);
            this.groupBoxAdd.Controls.Add(this.lblPhone);
            this.groupBoxAdd.Controls.Add(this.btnAddStudent);
            this.groupBoxAdd.Controls.Add(this.txStudentNumber);
            this.groupBoxAdd.Controls.Add(this.lblStudentNumber);
            this.groupBoxAdd.Controls.Add(this.comboCourses);
            this.groupBoxAdd.Controls.Add(this.lblCourse);
            this.groupBoxAdd.Controls.Add(this.radioPost);
            this.groupBoxAdd.Controls.Add(this.radioUnder);
            this.groupBoxAdd.Controls.Add(this.lblCourseLevel);
            this.groupBoxAdd.Controls.Add(this.comboBoxCounties);
            this.groupBoxAdd.Controls.Add(this.lblCounty);
            this.groupBoxAdd.Controls.Add(this.txtCity);
            this.groupBoxAdd.Controls.Add(this.lblCity);
            this.groupBoxAdd.Controls.Add(this.txtAdrline2);
            this.groupBoxAdd.Controls.Add(this.txtAdrline1);
            this.groupBoxAdd.Controls.Add(this.txtEmail);
            this.groupBoxAdd.Controls.Add(this.lblAdrline2);
            this.groupBoxAdd.Controls.Add(this.lblAdrline1);
            this.groupBoxAdd.Controls.Add(this.lblEmail);
            this.groupBoxAdd.Controls.Add(this.txtSurname);
            this.groupBoxAdd.Controls.Add(this.txtFirstName);
            this.groupBoxAdd.Controls.Add(this.lblSurname);
            this.groupBoxAdd.Controls.Add(this.lblFirstName);
            this.groupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 45);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(1016, 554);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Student Details";
            this.groupBoxAdd.Enter += new System.EventHandler(this.groupBoxAdd_Enter);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(179, 242);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(312, 29);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 247);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 24);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "Phone";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(427, 456);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 44);
            this.btnAddStudent.TabIndex = 20;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txStudentNumber
            // 
            this.txStudentNumber.Location = new System.Drawing.Point(775, 357);
            this.txStudentNumber.Name = "txStudentNumber";
            this.txStudentNumber.Size = new System.Drawing.Size(126, 29);
            this.txStudentNumber.TabIndex = 19;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(621, 364);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(148, 24);
            this.lblStudentNumber.TabIndex = 1;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // comboCourses
            // 
            this.comboCourses.FormattingEnabled = true;
            this.comboCourses.Items.AddRange(new object[] {
            "Business ",
            "Finance",
            "Information Systems",
            "Psychology",
            "Marketing"});
            this.comboCourses.Location = new System.Drawing.Point(697, 290);
            this.comboCourses.Name = "comboCourses";
            this.comboCourses.Size = new System.Drawing.Size(204, 32);
            this.comboCourses.TabIndex = 18;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(610, 298);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(71, 24);
            this.lblCourse.TabIndex = 17;
            this.lblCourse.Text = "Course";
            // 
            // radioPost
            // 
            this.radioPost.AutoSize = true;
            this.radioPost.Location = new System.Drawing.Point(808, 230);
            this.radioPost.Name = "radioPost";
            this.radioPost.Size = new System.Drawing.Size(138, 28);
            this.radioPost.TabIndex = 16;
            this.radioPost.Text = "Postgraduate";
            this.radioPost.UseVisualStyleBackColor = true;
            // 
            // radioUnder
            // 
            this.radioUnder.AutoSize = true;
            this.radioUnder.Checked = true;
            this.radioUnder.Location = new System.Drawing.Point(614, 230);
            this.radioUnder.Name = "radioUnder";
            this.radioUnder.Size = new System.Drawing.Size(154, 28);
            this.radioUnder.TabIndex = 15;
            this.radioUnder.TabStop = true;
            this.radioUnder.Text = "Undergraduate";
            this.radioUnder.UseVisualStyleBackColor = true;
            // 
            // lblCourseLevel
            // 
            this.lblCourseLevel.AutoSize = true;
            this.lblCourseLevel.Location = new System.Drawing.Point(719, 197);
            this.lblCourseLevel.Name = "lblCourseLevel";
            this.lblCourseLevel.Size = new System.Drawing.Size(121, 24);
            this.lblCourseLevel.TabIndex = 14;
            this.lblCourseLevel.Text = "Course Level";
            // 
            // comboBoxCounties
            // 
            this.comboBoxCounties.FormattingEnabled = true;
            this.comboBoxCounties.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.comboBoxCounties.Location = new System.Drawing.Point(658, 106);
            this.comboBoxCounties.Name = "comboBoxCounties";
            this.comboBoxCounties.Size = new System.Drawing.Size(152, 32);
            this.comboBoxCounties.TabIndex = 13;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(560, 110);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(69, 24);
            this.lblCounty.TabIndex = 12;
            this.lblCounty.Text = "County";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(658, 52);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(152, 29);
            this.txtCity.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(569, 58);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 24);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // txtAdrline2
            // 
            this.txtAdrline2.Location = new System.Drawing.Point(179, 376);
            this.txtAdrline2.Name = "txtAdrline2";
            this.txtAdrline2.Size = new System.Drawing.Size(312, 29);
            this.txtAdrline2.TabIndex = 9;
            // 
            // txtAdrline1
            // 
            this.txtAdrline1.Location = new System.Drawing.Point(179, 310);
            this.txtAdrline1.Name = "txtAdrline1";
            this.txtAdrline1.Size = new System.Drawing.Size(312, 29);
            this.txtAdrline1.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(179, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 29);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblAdrline2
            // 
            this.lblAdrline2.AutoSize = true;
            this.lblAdrline2.Location = new System.Drawing.Point(43, 381);
            this.lblAdrline2.Name = "lblAdrline2";
            this.lblAdrline2.Size = new System.Drawing.Size(125, 24);
            this.lblAdrline2.TabIndex = 6;
            this.lblAdrline2.Text = "Address line2";
            // 
            // lblAdrline1
            // 
            this.lblAdrline1.AutoSize = true;
            this.lblAdrline1.Location = new System.Drawing.Point(43, 313);
            this.lblAdrline1.Name = "lblAdrline1";
            this.lblAdrline1.Size = new System.Drawing.Size(125, 24);
            this.lblAdrline1.TabIndex = 5;
            this.lblAdrline1.Text = "Address line1";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(179, 118);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(312, 29);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(179, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(312, 29);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(47, 118);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(87, 24);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(43, 52);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 24);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.backToMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Serialise Student";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 631);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddStudent";
            this.Text = "New Student";
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.ComboBox comboBoxCounties;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAdrline2;
        private System.Windows.Forms.TextBox txtAdrline1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAdrline2;
        private System.Windows.Forms.Label lblAdrline1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txStudentNumber;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.ComboBox comboCourses;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.RadioButton radioPost;
        private System.Windows.Forms.RadioButton radioUnder;
        private System.Windows.Forms.Label lblCourseLevel;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}