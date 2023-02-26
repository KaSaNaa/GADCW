namespace Interface
{
    partial class Interface
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
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.Tab_Dashboard = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.Tab_Profile = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Tab_Quizzes = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Tab_Progress = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Tab_Calendar = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.Tab_Files = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.Linear;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.Tab_Dashboard);
            this.metroSetTabControl1.Controls.Add(this.Tab_Profile);
            this.metroSetTabControl1.Controls.Add(this.Tab_Quizzes);
            this.metroSetTabControl1.Controls.Add(this.Tab_Progress);
            this.metroSetTabControl1.Controls.Add(this.Tab_Calendar);
            this.metroSetTabControl1.Controls.Add(this.Tab_Files);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.HotTrack = true;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(50, 60);
            this.metroSetTabControl1.Location = new System.Drawing.Point(25, 140);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 5;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.ShowToolTips = true;
            this.metroSetTabControl1.Size = new System.Drawing.Size(847, 550);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 2;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            this.metroSetTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroSetTabControl1_SelectedIndexChanged);
            // 
            // Tab_Dashboard
            // 
            this.Tab_Dashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tab_Dashboard.Font = new System.Drawing.Font("Hubot-Sans Light Semi", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Dashboard.ImageIndex = 0;
            this.Tab_Dashboard.ImageKey = null;
            this.Tab_Dashboard.IsDerivedStyle = true;
            this.Tab_Dashboard.Location = new System.Drawing.Point(4, 64);
            this.Tab_Dashboard.Name = "Tab_Dashboard";
            this.Tab_Dashboard.Size = new System.Drawing.Size(839, 482);
            this.Tab_Dashboard.Style = MetroSet_UI.Enums.Style.Dark;
            this.Tab_Dashboard.StyleManager = this.styleManager1;
            this.Tab_Dashboard.TabIndex = 8;
            this.Tab_Dashboard.Text = "Dashboard         ";
            this.Tab_Dashboard.ThemeAuthor = "Narwin";
            this.Tab_Dashboard.ThemeName = "MetroDark";
            this.Tab_Dashboard.ToolTipText = null;
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Pasindu Ranawaka\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.x" +
    "ml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // Tab_Profile
            // 
            this.Tab_Profile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tab_Profile.Font = null;
            this.Tab_Profile.ImageIndex = 0;
            this.Tab_Profile.ImageKey = null;
            this.Tab_Profile.IsDerivedStyle = true;
            this.Tab_Profile.Location = new System.Drawing.Point(4, 64);
            this.Tab_Profile.Name = "Tab_Profile";
            this.Tab_Profile.Size = new System.Drawing.Size(839, 482);
            this.Tab_Profile.Style = MetroSet_UI.Enums.Style.Dark;
            this.Tab_Profile.StyleManager = this.styleManager1;
            this.Tab_Profile.TabIndex = 9;
            this.Tab_Profile.Text = "Profile";
            this.Tab_Profile.ThemeAuthor = "Narwin";
            this.Tab_Profile.ThemeName = "MetroDark";
            this.Tab_Profile.ToolTipText = null;
            // 
            // Tab_Quizzes
            // 
            this.Tab_Quizzes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tab_Quizzes.Font = null;
            this.Tab_Quizzes.ImageIndex = 0;
            this.Tab_Quizzes.ImageKey = null;
            this.Tab_Quizzes.IsDerivedStyle = true;
            this.Tab_Quizzes.Location = new System.Drawing.Point(4, 64);
            this.Tab_Quizzes.Name = "Tab_Quizzes";
            this.Tab_Quizzes.Size = new System.Drawing.Size(839, 482);
            this.Tab_Quizzes.Style = MetroSet_UI.Enums.Style.Dark;
            this.Tab_Quizzes.StyleManager = this.styleManager1;
            this.Tab_Quizzes.TabIndex = 11;
            this.Tab_Quizzes.Text = "Quizzes";
            this.Tab_Quizzes.ThemeAuthor = "Narwin";
            this.Tab_Quizzes.ThemeName = "MetroDark";
            this.Tab_Quizzes.ToolTipText = null;
            // 
            // Tab_Progress
            // 
            this.Tab_Progress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tab_Progress.Font = null;
            this.Tab_Progress.ImageIndex = 0;
            this.Tab_Progress.ImageKey = null;
            this.Tab_Progress.IsDerivedStyle = true;
            this.Tab_Progress.Location = new System.Drawing.Point(4, 64);
            this.Tab_Progress.Name = "Tab_Progress";
            this.Tab_Progress.Size = new System.Drawing.Size(839, 482);
            this.Tab_Progress.Style = MetroSet_UI.Enums.Style.Dark;
            this.Tab_Progress.StyleManager = this.styleManager1;
            this.Tab_Progress.TabIndex = 10;
            this.Tab_Progress.Text = "Progress";
            this.Tab_Progress.ThemeAuthor = "Narwin";
            this.Tab_Progress.ThemeName = "MetroDark";
            this.Tab_Progress.ToolTipText = null;
            // 
            // Tab_Calendar
            // 
            this.Tab_Calendar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tab_Calendar.Font = null;
            this.Tab_Calendar.ImageIndex = 0;
            this.Tab_Calendar.ImageKey = null;
            this.Tab_Calendar.IsDerivedStyle = true;
            this.Tab_Calendar.Location = new System.Drawing.Point(4, 64);
            this.Tab_Calendar.Name = "Tab_Calendar";
            this.Tab_Calendar.Size = new System.Drawing.Size(839, 482);
            this.Tab_Calendar.Style = MetroSet_UI.Enums.Style.Dark;
            this.Tab_Calendar.StyleManager = this.styleManager1;
            this.Tab_Calendar.TabIndex = 12;
            this.Tab_Calendar.Text = "Calendar";
            this.Tab_Calendar.ThemeAuthor = "Narwin";
            this.Tab_Calendar.ThemeName = "MetroDark";
            this.Tab_Calendar.ToolTipText = null;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(791, 6);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(5);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            this.metroSetControlBox1.Click += new System.EventHandler(this.metroSetControlBox1_Click);
            // 
            // Tab_Files
            // 
            this.Tab_Files.BaseColor = System.Drawing.Color.White;
            this.Tab_Files.Font = null;
            this.Tab_Files.ImageIndex = 0;
            this.Tab_Files.ImageKey = null;
            this.Tab_Files.IsDerivedStyle = true;
            this.Tab_Files.Location = new System.Drawing.Point(4, 64);
            this.Tab_Files.Name = "Tab_Files";
            this.Tab_Files.Size = new System.Drawing.Size(839, 482);
            this.Tab_Files.Style = MetroSet_UI.Enums.Style.Light;
            this.Tab_Files.StyleManager = null;
            this.Tab_Files.TabIndex = 13;
            this.Tab_Files.Text = "Files";
            this.Tab_Files.ThemeAuthor = "Narwin";
            this.Tab_Files.ThemeName = "MetroLite";
            this.Tab_Files.ToolTipText = null;
            // 
            // Interface
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Font = new System.Drawing.Font("Hubot-Sans Bold Semi", 26.77358F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Interface";
            this.Padding = new System.Windows.Forms.Padding(25, 140, 25, 23);
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "The Blob";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Child.MetroSetSetTabPage Tab_Dashboard;
        private MetroSet_UI.Child.MetroSetSetTabPage Tab_Profile;
        private MetroSet_UI.Child.MetroSetSetTabPage Tab_Progress;
        private MetroSet_UI.Child.MetroSetSetTabPage Tab_Quizzes;
        private MetroSet_UI.Child.MetroSetSetTabPage Tab_Calendar;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Child.MetroSetSetTabPage Tab_Files;
    }
}