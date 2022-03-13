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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 logForm = new Form1();
            logForm.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string memUserName = "";
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=ALEXPC;Initial Catalog=userdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connStr2 = "Data Source=ALEXPC;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            if (CheckFields(txtUserName.Text, PasswordTB.Text, FirstNameTB.Text, LastNameTB.Text, AgeTB.Text))
            {
                int.TryParse(AgeTB.Text, out int ageInt);
                if (PasswordTB.Text != RedPassTB.Text)
                {
                    MessageBox.Show("Passwords do not match..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string sqlExpression = $"INSERT INTO users (UserName, FirstName, LastName, Age, pass)" +
                        $" VALUES ('{txtUserName.Text}', '{FirstNameTB.Text}', '{LastNameTB.Text}', '{ageInt}', '{PasswordTB.Text}')";

                    using (SqlConnection connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            SqlCommand command = new SqlCommand(sqlExpression, connection);
                            try
                            {
                                command.ExecuteNonQuery();
                                Form1 form1 = new Form1();
                                form1.Show();
                                this.Hide();
                                MessageBox.Show("You registered successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                using (SqlConnection connection1 = new SqlConnection(connStr2)) 
                                {
                                    memUserName = txtUserName.Text;
                                    connection1.Open();
                                    string query = $"CREATE TABLE {memUserName}Table (ID INT PRIMARY KEY IDENTITY NOT NULL, TargetText NVARCHAR(50) NOT NULL)";
                                    SqlCommand command1 = new SqlCommand(query, connection1);
                                    command1.ExecuteNonQuery();
                                }
                            }
                            catch (Exception)
                            {

                                MessageBox.Show($"This username is already exist, take another username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Smth went wrong...");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Plaese fill all fields correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        static bool CheckFields(string userName, string password, string firstName, string lastName, string age)
        {
            if (password == "" || password == " ")
                return false;
            if (userName == "" || userName == " ")
                return false;
            if (firstName == "" || firstName == " ")
                return false;
            if (lastName == "" || lastName == " ")
                return false;
            if (!int.TryParse(age, out int ageInt))
            {
                MessageBox.Show("Plese enter your age correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (age == "" || age == " ")
                return false;
            return true;
        }

        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCB.Checked)
                PasswordTB.UseSystemPasswordChar = false;
            else
                PasswordTB.UseSystemPasswordChar = true;
        }

        private void ShowPassCB2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCB2.Checked)
                RedPassTB.UseSystemPasswordChar = false;
            else
                RedPassTB.UseSystemPasswordChar = true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AgeTB.Clear();
            PasswordTB.Clear();
            RedPassTB.Clear();
        }
    }
}
