using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Learning_Platform
{
    public partial class User_Profile : Form
    {
        public string FirstName
        {
            get { return txt_fname.Text; }
            set { txt_fname.Text = value; }
        }

        public string LastName
        {
            get { return txt_lname.Text; }
            set { txt_lname.Text = value; }
        }

        public string Email
        {
            get { return txt_mail.Text; }
            set { txt_mail.Text = value; }
        }

        public string Course
        {
            get { return txt_cname.Text; }
            set { txt_cname.Text = value; }
        }

        public string Username
        {
            get { return txt_username.Text; }
            set { txt_username.Text = value; }
        }

        public string Password
        {
            get { return txt_pwd.Text; }
            set { txt_pwd.Text = value; }
        }


        public User_Profile()
        {
            InitializeComponent();

        }

        private void StaticsChartData()
        {
            // remove the first series from the chart
            if (chart5.Series.Count > 0)
            {
                chart5.Series.RemoveAt(0);
            }


            var series = new Series("User Active %");

            
            series.Points.AddXY("Jan", 100);
            series.Points.AddXY("Feb", 50);
            series.Points.AddXY("Mar", 45);
            series.Points.AddXY("Apr", 100);
            series.Points.AddXY("May", 70);
            series.Points.AddXY("Jun", 45);
            series.Points.AddXY("July", 80);


            chart5.Series.Add(series);
  
        }

        private void QuizChartData()
        {
            if (chart2.Series.Count > 0)
            {
                chart2.Series.RemoveAt(0);
            }

            var series = new Series("Quiz Completion %");

            series.Points.AddXY("Programming", 98);
            series.Points.AddXY("Electronics", 60);
            series.Points.AddXY("Web Design", 45);
            series.Points.AddXY("Networking", 72);

            chart2.Series.Add(series);

        }
        private void User_Profile_Load(object sender, EventArgs e)
        {
            StaticsChartData();
            QuizChartData();
        }
    }
}
