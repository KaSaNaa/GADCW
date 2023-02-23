namespace Learning_Platform
{
    partial class Sign_In_Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.link_forgot_pwd = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_account = new MetroFramework.Controls.MetroTile();
            this.btn_back_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(256, 163);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(257, 30);
            this.txt_name.TabIndex = 2;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(256, 237);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(257, 30);
            this.txt_pwd.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.ActiveControl = null;
            this.btn_login.Location = new System.Drawing.Point(256, 312);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(257, 49);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Portal";
            // 
            // link_forgot_pwd
            // 
            this.link_forgot_pwd.AutoSize = true;
            this.link_forgot_pwd.Location = new System.Drawing.Point(374, 281);
            this.link_forgot_pwd.Name = "link_forgot_pwd";
            this.link_forgot_pwd.Size = new System.Drawing.Size(139, 16);
            this.link_forgot_pwd.TabIndex = 7;
            this.link_forgot_pwd.TabStop = true;
            this.link_forgot_pwd.Text = "Forgot the password ?";
            this.link_forgot_pwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgot_pwd_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // btn_account
            // 
            this.btn_account.ActiveControl = null;
            this.btn_account.Location = new System.Drawing.Point(256, 367);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(257, 49);
            this.btn_account.TabIndex = 9;
            this.btn_account.Text = "Create an account";
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_account.UseSelectable = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_back_user
            // 
            this.btn_back_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_user.Location = new System.Drawing.Point(12, 12);
            this.btn_back_user.Name = "btn_back_user";
            this.btn_back_user.Size = new System.Drawing.Size(75, 31);
            this.btn_back_user.TabIndex = 10;
            this.btn_back_user.Text = "<----";
            this.btn_back_user.UseVisualStyleBackColor = false;
            this.btn_back_user.Click += new System.EventHandler(this.btn_back_user_Click);
            // 
            // Sign_In_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_user);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_forgot_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Name = "Sign_In_Student";
            this.Text = "Sign_In_Student";
            this.Load += new System.EventHandler(this.Sign_In_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private MetroFramework.Controls.MetroTile btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_forgot_pwd;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btn_account;
        private System.Windows.Forms.Button btn_back_user;
    }
}

