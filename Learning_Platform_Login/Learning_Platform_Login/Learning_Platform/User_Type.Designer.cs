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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Type));
            this.btn_std_login = new MetroFramework.Controls.MetroTile();
            this.btn_lec_login = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Btn_Close = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_std_login
            // 
            this.btn_std_login.ActiveControl = null;
            this.btn_std_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_std_login.Location = new System.Drawing.Point(164, 141);
            this.btn_std_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_std_login.Name = "btn_std_login";
            this.btn_std_login.Size = new System.Drawing.Size(176, 156);
            this.btn_std_login.TabIndex = 0;
            this.btn_std_login.Text = "Student";
            this.btn_std_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_std_login.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_std_login.TileImage")));
            this.btn_std_login.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_std_login.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_std_login.UseCustomBackColor = true;
            this.btn_std_login.UseSelectable = true;
            this.btn_std_login.UseStyleColors = true;
            this.btn_std_login.UseTileImage = true;
            this.btn_std_login.Click += new System.EventHandler(this.btn_std_login_Click);
            // 
            // btn_lec_login
            // 
            this.btn_lec_login.ActiveControl = null;
            this.btn_lec_login.Location = new System.Drawing.Point(381, 141);
            this.btn_lec_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lec_login.Name = "btn_lec_login";
            this.btn_lec_login.Size = new System.Drawing.Size(176, 156);
            this.btn_lec_login.TabIndex = 1;
            this.btn_lec_login.Text = "Lecturer";
            this.btn_lec_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_lec_login.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_lec_login.TileImage")));
            this.btn_lec_login.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lec_login.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_lec_login.UseSelectable = true;
            this.btn_lec_login.UseStyleColors = true;
            this.btn_lec_login.UseTileImage = true;
            this.btn_lec_login.Click += new System.EventHandler(this.btn_lec_login_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.Btn_Close);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-5, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(732, 439);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(683, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(49, 39);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "X  ";
            this.Btn_Close.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_Close.UseCustomBackColor = true;
            this.Btn_Close.UseCustomForeColor = true;
            this.Btn_Close.UseMnemonic = false;
            this.Btn_Close.UseSelectable = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            this.Btn_Close.MouseHover += new System.EventHandler(this.Btn_Close_MouseHover);
            // 
            // User_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 437);
            this.Controls.Add(this.btn_lec_login);
            this.Controls.Add(this.btn_std_login);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Hubot-Sans SemiBold Semi", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 437);
            this.MinimumSize = new System.Drawing.Size(722, 437);
            this.Name = "User_Type";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Text = "Log in as";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_std_login;
        private MetroFramework.Controls.MetroTile btn_lec_login;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Btn_Close;
    }
}