namespace Learning_Platform
{
    partial class Sign_In_Student_Pwd
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_con_pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new MetroFramework.Controls.MetroTile();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(348, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "New Password";
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.White;
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(259, 212);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(290, 34);
            this.txt_pwd.TabIndex = 23;
            // 
            // txt_con_pwd
            // 
            this.txt_con_pwd.BackColor = System.Drawing.Color.White;
            this.txt_con_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_con_pwd.Location = new System.Drawing.Point(259, 306);
            this.txt_con_pwd.Name = "txt_con_pwd";
            this.txt_con_pwd.Size = new System.Drawing.Size(290, 34);
            this.txt_con_pwd.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(363, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(259, 115);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(290, 34);
            this.txt_username.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(335, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Confirm Password";
            // 
            // btn_confirm
            // 
            this.btn_confirm.ActiveControl = null;
            this.btn_confirm.BackColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(273, 374);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(263, 54);
            this.btn_confirm.TabIndex = 29;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_confirm.UseSelectable = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "Password Verification";
            // 
            // Sign_In_Student_Pwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_con_pwd);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label3);
            this.Name = "Sign_In_Student_Pwd";
            this.Text = "Sign_In_Student_Pwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_con_pwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btn_confirm;
        private System.Windows.Forms.Label label7;
    }
}