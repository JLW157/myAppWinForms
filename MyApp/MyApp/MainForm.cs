using MyApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Book_Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = HomeBtn.Height;
            homeControll1.BringToFront();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            string connStr2 = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr2))
            {
                connection.Open();
                string query = "DELETE unTable";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            homeControll1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HelpBtn.Height;
            SidePanel.Top = HelpBtn.Top;
            helpUserControll1.BringToFront();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = todoBtn.Height;
            SidePanel.Top = todoBtn.Top;
            toDoControll11.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
            monthTimeLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            string connStr2 = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr2))
            {
                connection.Open();
                string query = "DELETE unTable";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
