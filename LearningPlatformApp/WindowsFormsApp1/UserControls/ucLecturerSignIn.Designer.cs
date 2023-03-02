namespace WindowsFormsApp1.UserControls
{
    partial class ucLecturerSignIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_CreateAcc = new MetroFramework.Controls.MetroButton();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.Link_ForgotPswd = new MetroFramework.Controls.MetroLink();
            this.TxtB_Password = new MetroFramework.Controls.MetroTextBox();
            this.TxtB_Username = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_CreateAcc
            // 
            this.Btn_CreateAcc.Location = new System.Drawing.Point(472, 406);
            this.Btn_CreateAcc.Name = "Btn_CreateAcc";
            this.Btn_CreateAcc.Size = new System.Drawing.Size(193, 40);
            this.Btn_CreateAcc.Style = MetroFramework.MetroColorStyle.Blue;
            this.Btn_CreateAcc.TabIndex = 26;
            this.Btn_CreateAcc.Text = "Create Account";
            this.Btn_CreateAcc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_CreateAcc.UseSelectable = true;
            this.Btn_CreateAcc.Click += new System.EventHandler(this.Btn_CreateAcc_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(472, 351);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(193, 40);
            this.Btn_Login.Style = MetroFramework.MetroColorStyle.Blue;
            this.Btn_Login.TabIndex = 27;
            this.Btn_Login.Text = "Log In";
            this.Btn_Login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_Login.UseSelectable = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Link_ForgotPswd
            // 
            this.Link_ForgotPswd.BackColor = System.Drawing.Color.Transparent;
            this.Link_ForgotPswd.Location = new System.Drawing.Point(548, 315);
            this.Link_ForgotPswd.Name = "Link_ForgotPswd";
            this.Link_ForgotPswd.Size = new System.Drawing.Size(117, 23);
            this.Link_ForgotPswd.TabIndex = 25;
            this.Link_ForgotPswd.Text = "Forgot Password?";
            this.Link_ForgotPswd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Link_ForgotPswd.UseCustomBackColor = true;
            this.Link_ForgotPswd.UseSelectable = true;
            this.Link_ForgotPswd.Click += new System.EventHandler(this.Link_ForgotPswd_Click);
            // 
            // TxtB_Password
            // 
            // 
            // 
            // 
            this.TxtB_Password.CustomButton.Image = null;
            this.TxtB_Password.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.TxtB_Password.CustomButton.Name = "";
            this.TxtB_Password.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtB_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_Password.CustomButton.TabIndex = 1;
            this.TxtB_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Password.CustomButton.UseSelectable = true;
            this.TxtB_Password.CustomButton.Visible = false;
            this.TxtB_Password.Lines = new string[0];
            this.TxtB_Password.Location = new System.Drawing.Point(474, 277);
            this.TxtB_Password.MaxLength = 32767;
            this.TxtB_Password.Name = "TxtB_Password";
            this.TxtB_Password.PasswordChar = '\0';
            this.TxtB_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Password.SelectedText = "";
            this.TxtB_Password.SelectionLength = 0;
            this.TxtB_Password.SelectionStart = 0;
            this.TxtB_Password.ShortcutsEnabled = true;
            this.TxtB_Password.Size = new System.Drawing.Size(188, 32);
            this.TxtB_Password.TabIndex = 23;
            this.TxtB_Password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtB_Password.UseSelectable = true;
            this.TxtB_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtB_Username
            // 
            // 
            // 
            // 
            this.TxtB_Username.CustomButton.Image = null;
            this.TxtB_Username.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.TxtB_Username.CustomButton.Name = "";
            this.TxtB_Username.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtB_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtB_Username.CustomButton.TabIndex = 1;
            this.TxtB_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtB_Username.CustomButton.UseSelectable = true;
            this.TxtB_Username.CustomButton.Visible = false;
            this.TxtB_Username.Lines = new string[0];
            this.TxtB_Username.Location = new System.Drawing.Point(474, 217);
            this.TxtB_Username.MaxLength = 32767;
            this.TxtB_Username.Name = "TxtB_Username";
            this.TxtB_Username.PasswordChar = '\0';
            this.TxtB_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Username.SelectedText = "";
            this.TxtB_Username.SelectionLength = 0;
            this.TxtB_Username.SelectionStart = 0;
            this.TxtB_Username.ShortcutsEnabled = true;
            this.TxtB_Username.Size = new System.Drawing.Size(188, 32);
            this.TxtB_Username.TabIndex = 24;
            this.TxtB_Username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtB_Username.UseSelectable = true;
            this.TxtB_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtB_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Hubot-Sans Semi", 8.830189F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(469, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hubot-Sans ExtraBold Semi", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lecturer Sign-in";
            // 
            // ucLecturerSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_CreateAcc);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Link_ForgotPswd);
            this.Controls.Add(this.TxtB_Password);
            this.Controls.Add(this.TxtB_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ucLecturerSignIn";
            this.Size = new System.Drawing.Size(1136, 642);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ucLecturerSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_CreateAcc;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private MetroFramework.Controls.MetroLink Link_ForgotPswd;
        private MetroFramework.Controls.MetroTextBox TxtB_Password;
        private MetroFramework.Controls.MetroTextBox TxtB_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
