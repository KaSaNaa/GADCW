namespace Online_Evaluation_System
{
    partial class Lecturer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_ViewandDelete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateQuestion1 = new Online_Evaluation_System.Lecturer_usercontrols.UpdateQuestion();
            this.addNewQuestion1 = new Online_Evaluation_System.Lecturer_usercontrols.AddNewQuestion();
            this.view_DeleteQuestion1 = new Online_Evaluation_System.Lecturer_usercontrols.View_DeleteQuestion();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_ViewandDelete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(72, 340);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_ViewandDelete
            // 
            this.btn_ViewandDelete.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewandDelete.Location = new System.Drawing.Point(55, 222);
            this.btn_ViewandDelete.Name = "btn_ViewandDelete";
            this.btn_ViewandDelete.Size = new System.Drawing.Size(112, 85);
            this.btn_ViewandDelete.TabIndex = 2;
            this.btn_ViewandDelete.Text = "View & Delete Question";
            this.btn_ViewandDelete.UseVisualStyleBackColor = true;
            this.btn_ViewandDelete.Click += new System.EventHandler(this.btn_ViewandDelete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(55, 130);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 73);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update Question";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(55, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 67);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add New Question";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.view_DeleteQuestion1);
            this.panel2.Controls.Add(this.updateQuestion1);
            this.panel2.Controls.Add(this.addNewQuestion1);
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 450);
            this.panel2.TabIndex = 1;
            // 
            // updateQuestion1
            // 
            this.updateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.updateQuestion1.Name = "updateQuestion1";
            this.updateQuestion1.Size = new System.Drawing.Size(571, 450);
            this.updateQuestion1.TabIndex = 1;
            // 
            // addNewQuestion1
            // 
            this.addNewQuestion1.Location = new System.Drawing.Point(0, 0);
            this.addNewQuestion1.Name = "addNewQuestion1";
            this.addNewQuestion1.Size = new System.Drawing.Size(571, 450);
            this.addNewQuestion1.TabIndex = 0;
            // 
            // view_DeleteQuestion1
            // 
            this.view_DeleteQuestion1.Location = new System.Drawing.Point(0, 0);
            this.view_DeleteQuestion1.Name = "view_DeleteQuestion1";
            this.view_DeleteQuestion1.Size = new System.Drawing.Size(571, 450);
            this.view_DeleteQuestion1.TabIndex = 2;
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Lecturer";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_ViewandDelete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel2;
        private Lecturer_usercontrols.AddNewQuestion addNewQuestion1;
        private Lecturer_usercontrols.UpdateQuestion updateQuestion1;
        private Lecturer_usercontrols.View_DeleteQuestion view_DeleteQuestion1;
    }
}

