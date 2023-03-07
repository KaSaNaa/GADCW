using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Evaluation_System.Lecturer_usercontrols
{
    public partial class View_DeleteQuestion : UserControl
    {
        Function fn = new Function();
        String query;
        public View_DeleteQuestion()
        {
            InitializeComponent();
        }

        private void View_DeleteQuestion_Load(object sender, EventArgs e)
        {
            cmb_activity.Items.Clear();
            cmb_activity.Items.Add("All Questions");
            query = "select distinct activity from Questions";
            DataSet ds = fn.getData(query);

            for(int i = 0; i< ds.Tables[0].Rows.Count; i++)
            {
                cmb_activity.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            cmb_activity.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.ReadOnly = true;
        }

        private void cmb_activity_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmb_activity.SelectedIndex != 0)
                {
                    query = "select id,qno,question,option1,option2,option3,option4,ans from Questions where activity = '" + cmb_activity.Text + "'";
                    DataSet ds = fn.getData(query);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    query = "select id,qno,question,option1,option2,option3,option4,ans from Questions";
                    DataSet ds = fn.getData(query);
                    dataGridView1.DataSource = ds.Tables[0];
                }
        }

        int id, questionNO;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionNO = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch 
            { 

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            View_DeleteQuestion_Load(this, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_activity.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from Questions where id = "+id+" and qno = " + questionNO + "";
                    fn.setData(query, "Question deleted");

                    dataGridView1.DataSource = null;
                    View_DeleteQuestion_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Select Activity First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
