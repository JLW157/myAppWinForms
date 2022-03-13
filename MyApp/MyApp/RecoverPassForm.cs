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
    public partial class RecoverPassForm : Form
    {
        public RecoverPassForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=userdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExperession = $"SELECT UserName, FirstName, pass FROM users WHERE UserName = '{UserNameTB.Text}' AND FirstName = '{FirstNameTB.Text}'";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExperession, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object login = reader["UserName"];
                        object firstName = reader["FirstName"];
                        if (Convert.ToString(login) == UserNameTB.Text && Convert.ToString(firstName) == FirstNameTB.Text)
                        {
                            object password = reader["pass"];
                            passLabel.Text = password.ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UserNameTB.Clear();
            FirstNameTB.Clear();
            passLabel.Text = "here will be your password";
        }
    }
}
