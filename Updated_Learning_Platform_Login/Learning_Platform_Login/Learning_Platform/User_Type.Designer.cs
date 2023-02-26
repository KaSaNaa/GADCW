namespace Learning_Platform
{
    partial class User_Type
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
            this.btn_std_login = new MetroFramework.Controls.MetroTile();
            this.btn_lec_login = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btn_std_login
            // 
            this.btn_std_login.ActiveControl = null;
            this.btn_std_login.Location = new System.Drawing.Point(193, 167);
            this.btn_std_login.Name = "btn_std_login";
            this.btn_std_login.Size = new System.Drawing.Size(161, 127);
            this.btn_std_login.TabIndex = 0;
            this.btn_std_login.Text = "Student";
            this.btn_std_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_std_login.UseSelectable = true;
            this.btn_std_login.Click += new System.EventHandler(this.btn_std_login_Click);
            // 
            // btn_lec_login
            // 
            this.btn_lec_login.ActiveControl = null;
            this.btn_lec_login.Location = new System.Drawing.Point(441, 167);
            this.btn_lec_login.Name = "btn_lec_login";
            this.btn_lec_login.Size = new System.Drawing.Size(161, 127);
            this.btn_lec_login.TabIndex = 1;
            this.btn_lec_login.Text = "Lecturer";
            this.btn_lec_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lec_login.UseSelectable = true;
            this.btn_lec_login.Click += new System.EventHandler(this.btn_lec_login_Click);
            // 
            // User_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.btn_lec_login);
            this.Controls.Add(this.btn_std_login);
            this.Name = "User_Type";
            this.Text = "User_Type";
            this.Load += new System.EventHandler(this.User_Type_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_std_login;
        private MetroFramework.Controls.MetroTile btn_lec_login;
    }
}