using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Enums;

namespace Redesigned_Login_UI
{
    public partial class UserType : MetroSet_UI.Forms.MetroSetForm
    {
        public UserType()
        {
            InitializeComponent();
        }

        private void UserType_Load(object sender, EventArgs e)
        {

        }

        private void Tile_student_Click(object sender, EventArgs e)
        {
            Tile_student.Visible = false;
            Tile_teacher.Visible = false;
            var childForm = new Sign_In_Student_Pwd();
            childForm.ShowDialog();
            childForm.BringToFront();

        }

        private void Tile_teacher_Click(object sender, EventArgs e)
        {
            Tile_student.Visible = false;
            Tile_teacher.Visible = false;
            var childForm = new Sign_In_Teacher_Pwd();
            childForm.ShowDialog();
            childForm.BringToFront();
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}