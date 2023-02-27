namespace Redesigned_Login_UI
{
    partial class Sign_In_StudentPortal
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
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.TxtB_Username = new MetroSet_UI.Controls.MetroSetTextBox();
            this.TxtB_Password = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Btn_LogIn = new MetroSet_UI.Controls.MetroSetButton();
            this.Btn_CreateAcc = new MetroSet_UI.Controls.MetroSetButton();
            this.Link_ForgotPswd = new MetroSet_UI.Controls.MetroSetLink();
            this.Btn_GoBack = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Hubot-Sans", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(222, 84);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Username";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            this.metroSetLabel1.Click += new System.EventHandler(this.metroSetLabel1_Click);
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
            // TxtB_Username
            // 
            this.TxtB_Username.AutoCompleteCustomSource = null;
            this.TxtB_Username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtB_Username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtB_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.TxtB_Username.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TxtB_Username.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Username.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtB_Username.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TxtB_Username.Image = null;
            this.TxtB_Username.IsDerivedStyle = true;
            this.TxtB_Username.Lines = null;
            this.TxtB_Username.Location = new System.Drawing.Point(222, 110);
            this.TxtB_Username.MaxLength = 32767;
            this.TxtB_Username.Multiline = false;
            this.TxtB_Username.Name = "TxtB_Username";
            this.TxtB_Username.ReadOnly = false;
            this.TxtB_Username.Size = new System.Drawing.Size(135, 30);
            this.TxtB_Username.Style = MetroSet_UI.Enums.Style.Dark;
            this.TxtB_Username.StyleManager = this.styleManager1;
            this.TxtB_Username.TabIndex = 1;
            this.TxtB_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtB_Username.ThemeAuthor = "Narwin";
            this.TxtB_Username.ThemeName = "MetroDark";
            this.TxtB_Username.UseSystemPasswordChar = false;
            this.TxtB_Username.WatermarkText = "";
            this.TxtB_Username.Click += new System.EventHandler(this.TxtB_Username_Click);
            // 
            // TxtB_Password
            // 
            this.TxtB_Password.AutoCompleteCustomSource = null;
            this.TxtB_Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtB_Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtB_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.TxtB_Password.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TxtB_Password.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Password.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtB_Password.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TxtB_Password.Image = null;
            this.TxtB_Password.IsDerivedStyle = true;
            this.TxtB_Password.Lines = null;
            this.TxtB_Password.Location = new System.Drawing.Point(222, 201);
            this.TxtB_Password.MaxLength = 32767;
            this.TxtB_Password.Multiline = false;
            this.TxtB_Password.Name = "TxtB_Password";
            this.TxtB_Password.ReadOnly = false;
            this.TxtB_Password.Size = new System.Drawing.Size(135, 30);
            this.TxtB_Password.Style = MetroSet_UI.Enums.Style.Dark;
            this.TxtB_Password.StyleManager = this.styleManager1;
            this.TxtB_Password.TabIndex = 2;
            this.TxtB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtB_Password.ThemeAuthor = "Narwin";
            this.TxtB_Password.ThemeName = "MetroDark";
            this.TxtB_Password.UseSystemPasswordChar = false;
            this.TxtB_Password.WatermarkText = "";
            this.TxtB_Password.Click += new System.EventHandler(this.TxtB_Password_Click);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Hubot-Sans", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(222, 175);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 3;
            this.metroSetLabel2.Text = "Password";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            this.metroSetLabel2.Click += new System.EventHandler(this.metroSetLabel2_Click);
            // 
            // Btn_LogIn
            // 
            this.Btn_LogIn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_LogIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_LogIn.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_LogIn.Font = new System.Drawing.Font("Hubot-Sans", 10F);
            this.Btn_LogIn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_LogIn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_LogIn.HoverTextColor = System.Drawing.Color.White;
            this.Btn_LogIn.IsDerivedStyle = true;
            this.Btn_LogIn.Location = new System.Drawing.Point(222, 279);
            this.Btn_LogIn.Name = "Btn_LogIn";
            this.Btn_LogIn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_LogIn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_LogIn.NormalTextColor = System.Drawing.Color.White;
            this.Btn_LogIn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_LogIn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_LogIn.PressTextColor = System.Drawing.Color.White;
            this.Btn_LogIn.Size = new System.Drawing.Size(137, 32);
            this.Btn_LogIn.Style = MetroSet_UI.Enums.Style.Dark;
            this.Btn_LogIn.StyleManager = this.styleManager1;
            this.Btn_LogIn.TabIndex = 4;
            this.Btn_LogIn.Text = "Log In";
            this.Btn_LogIn.ThemeAuthor = "Narwin";
            this.Btn_LogIn.ThemeName = "MetroDark";
            this.Btn_LogIn.Click += new System.EventHandler(this.Btn_LogIn_Click);
            // 
            // Btn_CreateAcc
            // 
            this.Btn_CreateAcc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_CreateAcc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_CreateAcc.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_CreateAcc.Font = new System.Drawing.Font("Hubot-Sans", 10F);
            this.Btn_CreateAcc.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_CreateAcc.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_CreateAcc.HoverTextColor = System.Drawing.Color.White;
            this.Btn_CreateAcc.IsDerivedStyle = true;
            this.Btn_CreateAcc.Location = new System.Drawing.Point(220, 328);
            this.Btn_CreateAcc.Name = "Btn_CreateAcc";
            this.Btn_CreateAcc.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_CreateAcc.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_CreateAcc.NormalTextColor = System.Drawing.Color.White;
            this.Btn_CreateAcc.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_CreateAcc.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_CreateAcc.PressTextColor = System.Drawing.Color.White;
            this.Btn_CreateAcc.Size = new System.Drawing.Size(139, 32);
            this.Btn_CreateAcc.Style = MetroSet_UI.Enums.Style.Dark;
            this.Btn_CreateAcc.StyleManager = this.styleManager1;
            this.Btn_CreateAcc.TabIndex = 5;
            this.Btn_CreateAcc.Text = "Create Account";
            this.Btn_CreateAcc.ThemeAuthor = "Narwin";
            this.Btn_CreateAcc.ThemeName = "MetroDark";
            this.Btn_CreateAcc.Click += new System.EventHandler(this.Btn_CreateAcc_Click);
            // 
            // Link_ForgotPswd
            // 
            this.Link_ForgotPswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_ForgotPswd.Font = new System.Drawing.Font("Hubot-Sans Light Semi", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_ForgotPswd.IsDerivedStyle = true;
            this.Link_ForgotPswd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link_ForgotPswd.Location = new System.Drawing.Point(253, 234);
            this.Link_ForgotPswd.Name = "Link_ForgotPswd";
            this.Link_ForgotPswd.Size = new System.Drawing.Size(111, 23);
            this.Link_ForgotPswd.Style = MetroSet_UI.Enums.Style.Dark;
            this.Link_ForgotPswd.StyleManager = this.styleManager1;
            this.Link_ForgotPswd.TabIndex = 6;
            this.Link_ForgotPswd.TabStop = true;
            this.Link_ForgotPswd.Text = "Forgot password?";
            this.Link_ForgotPswd.ThemeAuthor = "Narwin";
            this.Link_ForgotPswd.ThemeName = "MetroDark";
            this.Link_ForgotPswd.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.Link_ForgotPswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ForgotPswd_LinkClicked);
            // 
            // Btn_GoBack
            // 
            this.Btn_GoBack.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_GoBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_GoBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_GoBack.Font = new System.Drawing.Font("Wingdings", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Btn_GoBack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_GoBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_GoBack.HoverTextColor = System.Drawing.Color.White;
            this.Btn_GoBack.IsDerivedStyle = true;
            this.Btn_GoBack.Location = new System.Drawing.Point(15, 181);
            this.Btn_GoBack.Name = "Btn_GoBack";
            this.Btn_GoBack.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_GoBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_GoBack.NormalTextColor = System.Drawing.Color.White;
            this.Btn_GoBack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_GoBack.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_GoBack.PressTextColor = System.Drawing.Color.White;
            this.Btn_GoBack.Size = new System.Drawing.Size(50, 50);
            this.Btn_GoBack.Style = MetroSet_UI.Enums.Style.Dark;
            this.Btn_GoBack.StyleManager = this.styleManager1;
            this.Btn_GoBack.TabIndex = 7;
            this.Btn_GoBack.Text = "ç";
            this.Btn_GoBack.ThemeAuthor = "Narwin";
            this.Btn_GoBack.ThemeName = "MetroDark";
            this.Btn_GoBack.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(480, -4);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = false;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 8;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // Sign_In_StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(585, 459);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.Btn_GoBack);
            this.Controls.Add(this.Link_ForgotPswd);
            this.Controls.Add(this.Btn_CreateAcc);
            this.Controls.Add(this.Btn_LogIn);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.TxtB_Password);
            this.Controls.Add(this.TxtB_Username);
            this.Controls.Add(this.metroSetLabel1);
            this.Font = new System.Drawing.Font("Hubot-Sans Bold Semi", 12.90566F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Sign_In_StudentPortal";
            this.Padding = new System.Windows.Forms.Padding(12, 67, 12, 11);
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Student Portal";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Sign_In_StudentPortal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox TxtB_Username;
        private MetroSet_UI.Controls.MetroSetTextBox TxtB_Password;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton Btn_LogIn;
        private MetroSet_UI.Controls.MetroSetButton Btn_CreateAcc;
        private MetroSet_UI.Controls.MetroSetLink Link_ForgotPswd;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetButton Btn_GoBack;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}