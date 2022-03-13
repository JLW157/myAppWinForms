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
using Book_Shop;

namespace MyApp
{
    public partial class ToDoItem : UserControl
    {
        public ToDoItem()
        {
            InitializeComponent();
        }
        string username;
        string memStr = "";
        public ToDoItem(string text, string userName)
        {
            InitializeComponent();
            label1.Text = text;
            username = userName;
        }

        
       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            NewTaskTB.Visible = true;
            ApplyPB.Visible = true;
            NewTaskTB.Text = label1.Text;
            NewTaskTB.BackColor = Color.RoyalBlue;
        }

        private void ApplyPB_Click_1(object sender, EventArgs e)
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                string query = $"UPDATE {username}Table SET TargetText = '{NewTaskTB.Text}' WHERE TargetText = '{label1.Text}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            NewTaskTB.Visible = false;
            ApplyPB.Visible = false;
            label1.Visible = true;
            label1.Text = NewTaskTB.Text;
        }

        private void BackUpPB_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                string query = $"INSERT INTO {username}Table VALUES ('{memStr}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            BackUpPB.Visible = false;
            this.BackColor = Color.RoyalBlue;
            NewTaskTB.Visible = false;
            ApplyPB.Visible = false;
            label1.Text = memStr;
            label1.Visible = true;
            pictureBox1.Visible = true;
            DeletePB.Visible = true;
        }

        private void DeletePB_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                string query = $"DELETE {username}Table WHERE TargetText = '{label1.Text}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            this.BackColor = Color.FromArgb(112, 112, 112);
            DeletePB.Visible = false;
            pictureBox1.Visible = false;
            ApplyPB.Visible = false;
            BackUpPB.Visible = true;
            NewTaskTB.BackColor = Color.FromArgb(112, 112, 112);
            NewTaskTB.ForeColor = Color.White;
            memStr = label1.Text;
            label1.Text = $"Deleted ({label1.Text}) {DateTime.Now.ToLongTimeString()}";
        }
    }
}
