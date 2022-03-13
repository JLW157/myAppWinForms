using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Shop;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyApp
{
    public partial class ToDoControll1 : UserControl
    {
        public ToDoControll1()
        {
            InitializeComponent();
            getUserName();
            getTargets();
        }
        
        string username;
        int poss = 10;
        public void addItem(string text)
        {
            ToDoItem item = new ToDoItem(text, username);
            panel3.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }
        void getUserName()
        {
            string connStr2 = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr2))
            {
                connection.Open();
                string query = "SELECT userName FROM unTable";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        username = reader["userName"].ToString();
                    }
                }
            }
        }
        void getTargets()
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                
                connection.Open();
                string query = $"SELECT * FROM {username}Table ORDER BY ID";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addItem($"{reader["TargetText"].ToString()}");
                    }
                }
            }
        }
        public void addTargets(string insert)
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                string query = $"INSERT INTO {username}Table VALUES ('{insert}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
       
        private void AddTaskPB_Click(object sender, EventArgs e)
        {
            if (TaskTB.Text == "" || TaskTB.Text == " ")
            {
                MessageBox.Show("Це поле не може бути пустим", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string tarName = TaskTB.Text;
                addItem(tarName);
                
                addTargets(tarName);
                TaskTB.Text = "";
            }
        }

        private void ToDoControll1_Load(object sender, EventArgs e)
        {

        }
    }
}
