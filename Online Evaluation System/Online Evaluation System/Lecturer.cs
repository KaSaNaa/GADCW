using Online_Evaluation_System.Lecturer_usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Evaluation_System
{
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateQuestion1.Visible = true;
            updateQuestion1.BringToFront();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = true;
            addNewQuestion1.BringToFront();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = false;
            updateQuestion1.Visible = false;
            view_DeleteQuestion1.Visible = false;
        }

        private void btn_ViewandDelete_Click(object sender, EventArgs e)
        {
            view_DeleteQuestion1.Visible = true;
            view_DeleteQuestion1.BringToFront();
        }
    }
}
