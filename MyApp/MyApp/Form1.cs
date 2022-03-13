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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.DarkBlue;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void loginButton_MouseClick(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.Blue;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            Hide();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string connStr2 = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connStr = "Data Source=ALEXPC;Initial Catalog=userdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExperession = $"SELECT UserName, pass FROM users WHERE UserName = '{UserNameTB2.Text}' AND pass = '{PasswordTB2.Text}'";

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
                        object password = reader["pass"];

                        if (Convert.ToString(login) == UserNameTB2.Text && Convert.ToString(password) == PasswordTB2.Text)
                        {
                            using (SqlConnection connection1 = new SqlConnection(connStr2))
                            {
                                connection1.Open();
                                string query = $"INSERT INTO unTable (userName) VALUES ('{UserNameTB2.Text}')";
                                SqlCommand command1 = new SqlCommand(query, connection1);
                                command1.ExecuteNonQuery();
                            }
                            MainForm main = new MainForm();
                            main.UsernameLbl.Text = "Hi, " + UserNameTB2.Text;
                            main.Show();
                            Hide();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("User doesn`t exist. Please register or check the correctness your input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            
        }

        private void ShowPassCB2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCB2.Checked)
                PasswordTB2.UseSystemPasswordChar = false;
            else
                PasswordTB2.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RecoverPassForm recoverPass = new RecoverPassForm();

            recoverPass.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
