namespace WindowsFormsApp1
{
    partial class studentDashboard
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
            this.tabCourses = new MetroFramework.Controls.MetroTabPage();
            this.tabQuizzes = new MetroFramework.Controls.MetroTabPage();
            this.tabCalendar = new MetroFramework.Controls.MetroTabPage();
            this.tabFiles = new MetroFramework.Controls.MetroTabPage();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.txt_fname = new MetroFramework.Controls.MetroLabel();
            this.txt_lname = new MetroFramework.Controls.MetroLabel();
            this.txt_mail = new MetroFramework.Controls.MetroLabel();
            this.txt_course = new MetroFramework.Controls.MetroLabel();
            this.txt_username = new MetroFramework.Controls.MetroLabel();
            this.txt_pwd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabLogout = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.profilePicPicker = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabCourses);
            this.tabControl.Controls.Add(this.tabQuizzes);
            this.tabControl.Controls.Add(this.tabCalendar);
            this.tabControl.Controls.Add(this.tabFiles);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabLogout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 5;
            this.tabControl.Size = new System.Drawing.Size(1310, 647);
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.UseSelectable = true;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.txt_pwd);
            this.tabDashboard.Controls.Add(this.txt_mail);
            this.tabDashboard.Controls.Add(this.txt_username);
            this.tabDashboard.Controls.Add(this.txt_course);
            this.tabDashboard.Controls.Add(this.txt_lname);
            this.tabDashboard.Controls.Add(this.metroLabel1);
            this.tabDashboard.Controls.Add(this.txt_fname);
            this.tabDashboard.HorizontalScrollbarBarColor = true;
            this.tabDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDashboard.HorizontalScrollbarSize = 10;
            this.tabDashboard.Location = new System.Drawing.Point(4, 44);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1302, 599);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "    Dashboard    ";
            this.tabDashboard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabDashboard.VerticalScrollbarBarColor = true;
            this.tabDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.tabDashboard.VerticalScrollbarSize = 10;
            // 
            // tabCourses
            // 
            this.tabCourses.HorizontalScrollbarBarColor = true;
            this.tabCourses.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCourses.HorizontalScrollbarSize = 10;
            this.tabCourses.Location = new System.Drawing.Point(4, 44);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Size = new System.Drawing.Size(1302, 599);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "    Courses    ";
            this.tabCourses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCourses.VerticalScrollbarBarColor = true;
            this.tabCourses.VerticalScrollbarHighlightOnWheel = false;
            this.tabCourses.VerticalScrollbarSize = 10;
            // 
            // tabQuizzes
            // 
            this.tabQuizzes.HorizontalScrollbarBarColor = true;
            this.tabQuizzes.HorizontalScrollbarHighlightOnWheel = false;
            this.tabQuizzes.HorizontalScrollbarSize = 10;
            this.tabQuizzes.Location = new System.Drawing.Point(4, 44);
            this.tabQuizzes.Name = "tabQuizzes";
            this.tabQuizzes.Size = new System.Drawing.Size(1302, 599);
            this.tabQuizzes.TabIndex = 2;
            this.tabQuizzes.Text = "    Quizzes    ";
            this.tabQuizzes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabQuizzes.VerticalScrollbarBarColor = true;
            this.tabQuizzes.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuizzes.VerticalScrollbarSize = 10;
            // 
            // tabCalendar
            // 
            this.tabCalendar.HorizontalScrollbarBarColor = true;
            this.tabCalendar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCalendar.HorizontalScrollbarSize = 10;
            this.tabCalendar.Location = new System.Drawing.Point(4, 44);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1302, 599);
            this.tabCalendar.TabIndex = 3;
            this.tabCalendar.Text = "    Calendar    ";
            this.tabCalendar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCalendar.VerticalScrollbarBarColor = true;
            this.tabCalendar.VerticalScrollbarHighlightOnWheel = false;
            this.tabCalendar.VerticalScrollbarSize = 10;
            // 
            // tabFiles
            // 
            this.tabFiles.HorizontalScrollbarBarColor = true;
            this.tabFiles.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFiles.HorizontalScrollbarSize = 10;
            this.tabFiles.Location = new System.Drawing.Point(4, 44);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Size = new System.Drawing.Size(1302, 599);
            this.tabFiles.TabIndex = 4;
            this.tabFiles.Text = "    FIles    ";
            this.tabFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFiles.VerticalScrollbarBarColor = true;
            this.tabFiles.VerticalScrollbarHighlightOnWheel = false;
            this.tabFiles.VerticalScrollbarSize = 10;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.metroLabel2);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 44);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1302, 599);
            this.tabSettings.TabIndex = 5;
            this.tabSettings.Text = "    Settings    ";
            this.tabSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // txt_fname
            // 
            this.txt_fname.AutoSize = true;
            this.txt_fname.BackColor = System.Drawing.Color.Transparent;
            this.txt_fname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_fname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_fname.ForeColor = System.Drawing.Color.White;
            this.txt_fname.Location = new System.Drawing.Point(97, 17);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(127, 25);
            this.txt_fname.TabIndex = 2;
            this.txt_fname.Text = "@USERNAME";
            this.txt_fname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_fname.UseCustomForeColor = true;
            // 
            // txt_lname
            // 
            this.txt_lname.AutoSize = true;
            this.txt_lname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_lname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_lname.Location = new System.Drawing.Point(258, 166);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(117, 25);
            this.txt_lname.TabIndex = 2;
            this.txt_lname.Text = "metroLabel1";
            this.txt_lname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_mail
            // 
            this.txt_mail.AutoSize = true;
            this.txt_mail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_mail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_mail.Location = new System.Drawing.Point(376, 166);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(117, 25);
            this.txt_mail.TabIndex = 2;
            this.txt_mail.Text = "metroLabel1";
            this.txt_mail.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_course
            // 
            this.txt_course.AutoSize = true;
            this.txt_course.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_course.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_course.Location = new System.Drawing.Point(479, 166);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(117, 25);
            this.txt_course.TabIndex = 2;
            this.txt_course.Text = "metroLabel1";
            this.txt_course.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_username.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_username.Location = new System.Drawing.Point(587, 166);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(117, 25);
            this.txt_username.TabIndex = 2;
            this.txt_username.Text = "metroLabel1";
            this.txt_username.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_pwd
            // 
            this.txt_pwd.AutoSize = true;
            this.txt_pwd.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_pwd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_pwd.Location = new System.Drawing.Point(689, 166);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(117, 25);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Text = "metroLabel1";
            this.txt_pwd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(8, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Welcome,";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabLogout
            // 
            this.tabLogout.HorizontalScrollbarBarColor = true;
            this.tabLogout.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLogout.HorizontalScrollbarSize = 10;
            this.tabLogout.Location = new System.Drawing.Point(4, 44);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(1302, 599);
            this.tabLogout.TabIndex = 6;
            this.tabLogout.Text = "    Logout    ";
            this.tabLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabLogout.VerticalScrollbarBarColor = true;
            this.tabLogout.VerticalScrollbarHighlightOnWheel = false;
            this.tabLogout.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(71, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(203, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Upload a profile picture:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // profilePicPicker
            // 
            this.profilePicPicker.FileName = "openFileDialog1";
            this.profilePicPicker.Filter = "JPG files|*.jpg, *jpeg|Image Files|*.jpeg*";
            // 
            // studentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.tabControl);
            this.Name = "studentDashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabDashboard;
        private MetroFramework.Controls.MetroTabPage tabCourses;
        private MetroFramework.Controls.MetroTabPage tabQuizzes;
        private MetroFramework.Controls.MetroTabPage tabCalendar;
        private MetroFramework.Controls.MetroTabPage tabFiles;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroLabel txt_mail;
        private MetroFramework.Controls.MetroLabel txt_lname;
        private MetroFramework.Controls.MetroLabel txt_fname;
        private MetroFramework.Controls.MetroLabel txt_pwd;
        private MetroFramework.Controls.MetroLabel txt_username;
        private MetroFramework.Controls.MetroLabel txt_course;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage tabLogout;
        private System.Windows.Forms.OpenFileDialog profilePicPicker;
    }
}