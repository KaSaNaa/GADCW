namespace WindowsFormsApp1
{
    partial class frmCreateAccount
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
            this.CheckBox_Terms = new MetroFramework.Controls.MetroCheckBox();
            this.BirthDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.Btn_CreateAcc = new MetroFramework.Controls.MetroButton();
            this.TxtB_Email = new MetroFramework.Controls.MetroTextBox();
            this.TxtB_Password = new MetroFramework.Controls.MetroTextBox();
            this.TxtB_ConfirmPswd = new MetroFramework.Controls.MetroTextBox();
            this.TxtB_Lname = new MetroFramework.Controls.MetroTextBox();
            this.TxtB_Fname = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioStudent = new MetroFramework.Controls.MetroRadioButton();
            this.radioLecturer = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckBox_Terms
            // 
            this.CheckBox_Terms.AutoSize = true;
            this.CheckBox_Terms.Location = new System.Drawing.Point(325, 498);
            this.CheckBox_Terms.Name = "CheckBox_Terms";
            this.CheckBox_Terms.Size = new System.Drawing.Size(378, 17);
            this.CheckBox_Terms.TabIndex = 43;
            this.CheckBox_Terms.Text = "I acknowledge and accept the terms and conditions outlined.";
            this.CheckBox_Terms.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CheckBox_Terms.UseSelectable = true;
            this.CheckBox_Terms.CheckedChanged += new System.EventHandler(this.CheckBox_Terms_CheckedChanged);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(318, 303);
            this.BirthDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(249, 29);
            this.BirthDatePicker.TabIndex = 42;
            this.BirthDatePicker.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Btn_CreateAcc
            // 
            this.Btn_CreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Btn_CreateAcc.ForeColor = System.Drawing.Color.White;
            this.Btn_CreateAcc.Location = new System.Drawing.Point(464, 549);
            this.Btn_CreateAcc.Name = "Btn_CreateAcc";
            this.Btn_CreateAcc.Size = new System.Drawing.Size(195, 42);
            this.Btn_CreateAcc.Style = MetroFramework.MetroColorStyle.Blue;
            this.Btn_CreateAcc.TabIndex = 28;
            this.Btn_CreateAcc.Text = "Create Account";
            this.Btn_CreateAcc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_CreateAcc.UseSelectable = true;
            this.Btn_CreateAcc.Click += new System.EventHandler(this.Btn_CreateAcc_Click);
            // 
            // TxtB_Email
            // 
            // 
            // 
            // 
            this.TxtB_Email.CustomButton.Image = null;
            this.TxtB_Email.CustomButton.Location = new System.Drawing.Point(466, 2);
            this.TxtB_Email.CustomButton.Name = "";
            this.TxtB_Email.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtB_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_Email.CustomButton.TabIndex = 1;
            this.TxtB_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Email.CustomButton.UseSelectable = true;
            this.TxtB_Email.CustomButton.Visible = false;
            this.TxtB_Email.Lines = new string[0];
            this.TxtB_Email.Location = new System.Drawing.Point(318, 217);
            this.TxtB_Email.MaxLength = 32767;
            this.TxtB_Email.Name = "TxtB_Email";
            this.TxtB_Email.PasswordChar = '\0';
            this.TxtB_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Email.SelectedText = "";
            this.TxtB_Email.SelectionLength = 0;
            this.TxtB_Email.SelectionStart = 0;
            this.TxtB_Email.ShortcutsEnabled = true;
            this.TxtB_Email.Size = new System.Drawing.Size(492, 28);
            this.TxtB_Email.TabIndex = 36;
            this.TxtB_Email.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Email.UseSelectable = true;
            this.TxtB_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtB_Password
            // 
            // 
            // 
            // 
            this.TxtB_Password.CustomButton.Image = null;
            this.TxtB_Password.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.TxtB_Password.CustomButton.Name = "";
            this.TxtB_Password.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtB_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_Password.CustomButton.TabIndex = 1;
            this.TxtB_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Password.CustomButton.UseSelectable = true;
            this.TxtB_Password.CustomButton.Visible = false;
            this.TxtB_Password.Lines = new string[0];
            this.TxtB_Password.Location = new System.Drawing.Point(325, 453);
            this.TxtB_Password.MaxLength = 32767;
            this.TxtB_Password.Name = "TxtB_Password";
            this.TxtB_Password.PasswordChar = '\0';
            this.TxtB_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Password.SelectedText = "";
            this.TxtB_Password.SelectionLength = 0;
            this.TxtB_Password.SelectionStart = 0;
            this.TxtB_Password.ShortcutsEnabled = true;
            this.TxtB_Password.Size = new System.Drawing.Size(219, 28);
            this.TxtB_Password.TabIndex = 37;
            this.TxtB_Password.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Password.UseSelectable = true;
            this.TxtB_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtB_ConfirmPswd
            // 
            // 
            // 
            // 
            this.TxtB_ConfirmPswd.CustomButton.Image = null;
            this.TxtB_ConfirmPswd.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.TxtB_ConfirmPswd.CustomButton.Name = "";
            this.TxtB_ConfirmPswd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtB_ConfirmPswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_ConfirmPswd.CustomButton.TabIndex = 1;
            this.TxtB_ConfirmPswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_ConfirmPswd.CustomButton.UseSelectable = true;
            this.TxtB_ConfirmPswd.CustomButton.Visible = false;
            this.TxtB_ConfirmPswd.Lines = new string[0];
            this.TxtB_ConfirmPswd.Location = new System.Drawing.Point(592, 453);
            this.TxtB_ConfirmPswd.MaxLength = 32767;
            this.TxtB_ConfirmPswd.Name = "TxtB_ConfirmPswd";
            this.TxtB_ConfirmPswd.PasswordChar = '\0';
            this.TxtB_ConfirmPswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_ConfirmPswd.SelectedText = "";
            this.TxtB_ConfirmPswd.SelectionLength = 0;
            this.TxtB_ConfirmPswd.SelectionStart = 0;
            this.TxtB_ConfirmPswd.ShortcutsEnabled = true;
            this.TxtB_ConfirmPswd.Size = new System.Drawing.Size(219, 28);
            this.TxtB_ConfirmPswd.TabIndex = 38;
            this.TxtB_ConfirmPswd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_ConfirmPswd.UseSelectable = true;
            this.TxtB_ConfirmPswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_ConfirmPswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtB_Lname
            // 
            // 
            // 
            // 
            this.TxtB_Lname.CustomButton.Image = null;
            this.TxtB_Lname.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.TxtB_Lname.CustomButton.Name = "";
            this.TxtB_Lname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtB_Lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_Lname.CustomButton.TabIndex = 1;
            this.TxtB_Lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Lname.CustomButton.UseSelectable = true;
            this.TxtB_Lname.CustomButton.Visible = false;
            this.TxtB_Lname.Lines = new string[0];
            this.TxtB_Lname.Location = new System.Drawing.Point(592, 129);
            this.TxtB_Lname.MaxLength = 32767;
            this.TxtB_Lname.Name = "TxtB_Lname";
            this.TxtB_Lname.PasswordChar = '\0';
            this.TxtB_Lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Lname.SelectedText = "";
            this.TxtB_Lname.SelectionLength = 0;
            this.TxtB_Lname.SelectionStart = 0;
            this.TxtB_Lname.ShortcutsEnabled = true;
            this.TxtB_Lname.Size = new System.Drawing.Size(219, 28);
            this.TxtB_Lname.TabIndex = 40;
            this.TxtB_Lname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Lname.UseSelectable = true;
            this.TxtB_Lname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Lname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtB_Fname
            // 
            // 
            // 
            // 
            this.TxtB_Fname.CustomButton.Image = null;
            this.TxtB_Fname.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.TxtB_Fname.CustomButton.Name = "";
            this.TxtB_Fname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtB_Fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_Fname.CustomButton.TabIndex = 1;
            this.TxtB_Fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Fname.CustomButton.UseSelectable = true;
            this.TxtB_Fname.CustomButton.Visible = false;
            this.TxtB_Fname.Lines = new string[0];
            this.TxtB_Fname.Location = new System.Drawing.Point(318, 129);
            this.TxtB_Fname.MaxLength = 32767;
            this.TxtB_Fname.Name = "TxtB_Fname";
            this.TxtB_Fname.PasswordChar = '\0';
            this.TxtB_Fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Fname.SelectedText = "";
            this.TxtB_Fname.SelectionLength = 0;
            this.TxtB_Fname.SelectionStart = 0;
            this.TxtB_Fname.ShortcutsEnabled = true;
            this.TxtB_Fname.Size = new System.Drawing.Size(219, 28);
            this.TxtB_Fname.TabIndex = 41;
            this.TxtB_Fname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Fname.UseSelectable = true;
            this.TxtB_Fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(316, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(591, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(324, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(315, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(321, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(590, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last name";
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(146, 12);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(68, 17);
            this.radioStudent.TabIndex = 44;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseSelectable = true;
            // 
            // radioLecturer
            // 
            this.radioLecturer.AutoSize = true;
            this.radioLecturer.Location = new System.Drawing.Point(276, 12);
            this.radioLecturer.Name = "radioLecturer";
            this.radioLecturer.Size = new System.Drawing.Size(71, 17);
            this.radioLecturer.TabIndex = 44;
            this.radioLecturer.Text = "Lecturer";
            this.radioLecturer.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioLecturer);
            this.groupBox1.Controls.Add(this.radioStudent);
            this.groupBox1.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.groupBox1.Location = new System.Drawing.Point(318, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 39);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Type:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckBox_Terms);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.Btn_CreateAcc);
            this.Controls.Add(this.TxtB_Email);
            this.Controls.Add(this.TxtB_Password);
            this.Controls.Add(this.TxtB_ConfirmPswd);
            this.Controls.Add(this.TxtB_Lname);
            this.Controls.Add(this.TxtB_Fname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmCreateAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.frmCreateAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox CheckBox_Terms;
        private MetroFramework.Controls.MetroDateTime BirthDatePicker;
        private MetroFramework.Controls.MetroButton Btn_CreateAcc;
        private MetroFramework.Controls.MetroTextBox TxtB_Email;
        private MetroFramework.Controls.MetroTextBox TxtB_Password;
        private MetroFramework.Controls.MetroTextBox TxtB_ConfirmPswd;
        private MetroFramework.Controls.MetroTextBox TxtB_Lname;
        private MetroFramework.Controls.MetroTextBox TxtB_Fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroRadioButton radioStudent;
        private MetroFramework.Controls.MetroRadioButton radioLecturer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}