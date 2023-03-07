namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabDashboard = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_fname = new MetroFramework.Controls.MetroLabel();
            this.tabFiles = new MetroFramework.Controls.MetroTabPage();
            this.tabCalendar = new MetroFramework.Controls.MetroTabPage();
            this.tabQuizzes = new MetroFramework.Controls.MetroTabPage();
            this.tabCourses = new MetroFramework.Controls.MetroTabPage();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.browse = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabLogout = new MetroFramework.Controls.MetroTabPage();
            this.txt_username = new MetroFramework.Controls.MetroLabel();
            this.txt_lname = new MetroFramework.Controls.MetroLabel();
            this.txt_mail = new MetroFramework.Controls.MetroLabel();
            this.txt_usertype = new MetroFramework.Controls.MetroLabel();
            this.txt_course = new MetroFramework.Controls.MetroLabel();
            this.txt_pwd = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabFiles);
            this.tabControl.Controls.Add(this.tabCalendar);
            this.tabControl.Controls.Add(this.tabQuizzes);
            this.tabControl.Controls.Add(this.tabCourses);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabLogout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1379, 757);
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.UseSelectable = true;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.pictureBox1);
            this.tabDashboard.Controls.Add(this.txt_fname);
            this.tabDashboard.HorizontalScrollbarBarColor = true;
            this.tabDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDashboard.HorizontalScrollbarSize = 10;
            this.tabDashboard.Location = new System.Drawing.Point(4, 44);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1371, 709);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "    Dashboard    ";
            this.tabDashboard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabDashboard.VerticalScrollbarBarColor = true;
            this.tabDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.tabDashboard.VerticalScrollbarSize = 10;
            this.tabDashboard.Click += new System.EventHandler(this.tabDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1134, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 211);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_fname
            // 
            this.txt_fname.AutoSize = true;
            this.txt_fname.BackColor = System.Drawing.Color.Transparent;
            this.txt_fname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_fname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_fname.ForeColor = System.Drawing.Color.White;
            this.txt_fname.Location = new System.Drawing.Point(3, 11);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(137, 25);
            this.txt_fname.TabIndex = 2;
            this.txt_fname.Text = "Welcome, User";
            this.txt_fname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_fname.UseCustomForeColor = true;
            // 
            // tabFiles
            // 
            this.tabFiles.HorizontalScrollbarBarColor = true;
            this.tabFiles.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFiles.HorizontalScrollbarSize = 10;
            this.tabFiles.Location = new System.Drawing.Point(4, 44);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Size = new System.Drawing.Size(1371, 709);
            this.tabFiles.TabIndex = 4;
            this.tabFiles.Text = "    Files    ";
            this.tabFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFiles.VerticalScrollbarBarColor = true;
            this.tabFiles.VerticalScrollbarHighlightOnWheel = false;
            this.tabFiles.VerticalScrollbarSize = 10;
            // 
            // tabCalendar
            // 
            this.tabCalendar.HorizontalScrollbarBarColor = true;
            this.tabCalendar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCalendar.HorizontalScrollbarSize = 10;
            this.tabCalendar.Location = new System.Drawing.Point(4, 44);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1371, 709);
            this.tabCalendar.TabIndex = 3;
            this.tabCalendar.Text = "    Calendar    ";
            this.tabCalendar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCalendar.VerticalScrollbarBarColor = true;
            this.tabCalendar.VerticalScrollbarHighlightOnWheel = false;
            this.tabCalendar.VerticalScrollbarSize = 10;
            // 
            // tabQuizzes
            // 
            this.tabQuizzes.HorizontalScrollbarBarColor = true;
            this.tabQuizzes.HorizontalScrollbarHighlightOnWheel = false;
            this.tabQuizzes.HorizontalScrollbarSize = 10;
            this.tabQuizzes.Location = new System.Drawing.Point(4, 44);
            this.tabQuizzes.Name = "tabQuizzes";
            this.tabQuizzes.Size = new System.Drawing.Size(1371, 709);
            this.tabQuizzes.TabIndex = 2;
            this.tabQuizzes.Text = "    Quizzes    ";
            this.tabQuizzes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabQuizzes.VerticalScrollbarBarColor = true;
            this.tabQuizzes.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuizzes.VerticalScrollbarSize = 10;
            // 
            // tabCourses
            // 
            this.tabCourses.HorizontalScrollbarBarColor = true;
            this.tabCourses.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCourses.HorizontalScrollbarSize = 10;
            this.tabCourses.Location = new System.Drawing.Point(4, 44);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Size = new System.Drawing.Size(1371, 709);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "    Courses    ";
            this.tabCourses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCourses.VerticalScrollbarBarColor = true;
            this.tabCourses.VerticalScrollbarHighlightOnWheel = false;
            this.tabCourses.VerticalScrollbarSize = 10;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.browse);
            this.tabSettings.Controls.Add(this.metroButton2);
            this.tabSettings.Controls.Add(this.metroTextBox1);
            this.tabSettings.Controls.Add(this.metroLabel1);
            this.tabSettings.Controls.Add(this.metroLabel2);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 44);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1371, 709);
            this.tabSettings.TabIndex = 5;
            this.tabSettings.Text = "    Settings    ";
            this.tabSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            this.tabSettings.Click += new System.EventHandler(this.tabSettings_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(518, 103);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 7;
            this.browse.Text = "Browse";
            this.browse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.browse.UseSelectable = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(347, 150);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(99, 35);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Upload";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(280, 103);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(232, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(169, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Select a file:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(71, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(193, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Change profile picture:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // tabLogout
            // 
            this.tabLogout.HorizontalScrollbarBarColor = true;
            this.tabLogout.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLogout.HorizontalScrollbarSize = 10;
            this.tabLogout.Location = new System.Drawing.Point(4, 44);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(1371, 709);
            this.tabLogout.TabIndex = 6;
            this.tabLogout.Text = "    Logout    ";
            this.tabLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabLogout.VerticalScrollbarBarColor = true;
            this.tabLogout.VerticalScrollbarHighlightOnWheel = false;
            this.tabLogout.VerticalScrollbarSize = 10;
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_username.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(56, 21);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(137, 25);
            this.txt_username.TabIndex = 2;
            this.txt_username.Text = "Welcome, User";
            this.txt_username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_username.UseCustomForeColor = true;
            // 
            // txt_lname
            // 
            this.txt_lname.AutoSize = true;
            this.txt_lname.BackColor = System.Drawing.Color.Transparent;
            this.txt_lname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_lname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_lname.ForeColor = System.Drawing.Color.White;
            this.txt_lname.Location = new System.Drawing.Point(209, 21);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(137, 25);
            this.txt_lname.TabIndex = 2;
            this.txt_lname.Text = "Welcome, User";
            this.txt_lname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_lname.UseCustomForeColor = true;
            // 
            // txt_mail
            // 
            this.txt_mail.AutoSize = true;
            this.txt_mail.BackColor = System.Drawing.Color.Transparent;
            this.txt_mail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_mail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_mail.ForeColor = System.Drawing.Color.White;
            this.txt_mail.Location = new System.Drawing.Point(352, 21);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(137, 25);
            this.txt_mail.TabIndex = 2;
            this.txt_mail.Text = "Welcome, User";
            this.txt_mail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_mail.UseCustomForeColor = true;
            // 
            // txt_usertype
            // 
            this.txt_usertype.AutoSize = true;
            this.txt_usertype.BackColor = System.Drawing.Color.Transparent;
            this.txt_usertype.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_usertype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_usertype.ForeColor = System.Drawing.Color.White;
            this.txt_usertype.Location = new System.Drawing.Point(495, 21);
            this.txt_usertype.Name = "txt_usertype";
            this.txt_usertype.Size = new System.Drawing.Size(137, 25);
            this.txt_usertype.TabIndex = 2;
            this.txt_usertype.Text = "Welcome, User";
            this.txt_usertype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_usertype.UseCustomForeColor = true;
            // 
            // txt_course
            // 
            this.txt_course.AutoSize = true;
            this.txt_course.BackColor = System.Drawing.Color.Transparent;
            this.txt_course.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_course.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_course.ForeColor = System.Drawing.Color.White;
            this.txt_course.Location = new System.Drawing.Point(638, 21);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(137, 25);
            this.txt_course.TabIndex = 2;
            this.txt_course.Text = "Welcome, User";
            this.txt_course.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_course.UseCustomForeColor = true;
            // 
            // txt_pwd
            // 
            this.txt_pwd.AutoSize = true;
            this.txt_pwd.BackColor = System.Drawing.Color.Transparent;
            this.txt_pwd.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_pwd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_pwd.ForeColor = System.Drawing.Color.White;
            this.txt_pwd.Location = new System.Drawing.Point(781, 21);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(137, 25);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Text = "Welcome, User";
            this.txt_pwd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_pwd.UseCustomForeColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 837);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.txt_usertype);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_username);
            this.Name = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.studentDashboard_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabDashboard;
        private MetroFramework.Controls.MetroTabPage tabCourses;
        private MetroFramework.Controls.MetroTabPage tabQuizzes;
        private MetroFramework.Controls.MetroTabPage tabCalendar;
        private MetroFramework.Controls.MetroTabPage tabFiles;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroLabel txt_fname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage tabLogout;
        private MetroFramework.Controls.MetroLabel txt_username;
        private MetroFramework.Controls.MetroLabel txt_lname;
        private MetroFramework.Controls.MetroLabel txt_mail;
        private MetroFramework.Controls.MetroLabel txt_usertype;
        private MetroFramework.Controls.MetroLabel txt_pwd;
        private MetroFramework.Controls.MetroLabel txt_course;
        private MetroFramework.Controls.MetroButton browse;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}