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
    public partial class UpdateQuestion : UserControl

    {
        Function fn = new Function();
        String query;

        public UpdateQuestion()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {
            cmb_activity.Items.Clear();
            query = "select distinct activity from Questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb_activity.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
            cmb_activity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_questionNo.DropDownStyle = ComboBoxStyle.DropDownList;

            txt_question.Enabled = false;
            txt_option1.Enabled = false;
            txt_option2.Enabled = false;
            txt_option3.Enabled = false;
            txt_option4.Enabled = false;
            txt_ans.Enabled = false;

        }

        private void cmb_activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_questionNo.Items.Clear();
            query = "select qno from Questions where activity = '" + cmb_activity.Text + "'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb_questionNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cmb_questionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select question,option1,option2,option3,option4,ans from Questions where activity ='" + cmb_activity.Text + "' and qno = '" + cmb_questionNo.Text + "'";
             DataSet ds = fn.getData(query);

            txt_question.Enabled = true;
            txt_option1.Enabled = true;
            txt_option2.Enabled = true;
            txt_option3.Enabled = true;
            txt_option4.Enabled = true;
            txt_ans.Enabled = true;

            txt_question.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_option1.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_option2.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_option3.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_option4.Text = ds.Tables[0].Rows[0][4].ToString();
            txt_ans.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            clearAll();
        }

        public void clearAll()
        {
            txt_question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();
            txt_ans.Clear();
            cmb_activity.SelectedIndex = -1;
            cmb_questionNo.SelectedIndex = -1;

            txt_question.Enabled = false;
            txt_option1.Enabled = false;
            txt_option2.Enabled = false;
            txt_option3.Enabled = false;
            txt_option4.Enabled = false;
            txt_ans.Enabled = false;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(cmb_questionNo.SelectedIndex != -1)
            {
                String activity = cmb_activity.Text;
                String qno = cmb_questionNo.Text;
                String question = txt_question.Text;
                String option1 = txt_option1.Text;
                String option2 = txt_option2.Text;
                String option3 = txt_option3.Text;
                String option4 = txt_option3.Text;
                String ans = txt_ans.Text;

                query = "update Questions set question = '" + question + "', option1 = '" + option1 + "', option2 ='" + option2 + "', option3='" + option3 + "', option4 = '" + option4 + "', ans = '" + ans + "' where activity = '"+activity+"'and qno = '"+qno+"'";
                fn.setData(query, "Question No: "+qno+" \n Activity: "+activity+" \n is Updated. ");
            }
            else
            {
                MessageBox.Show("Select Question number First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}