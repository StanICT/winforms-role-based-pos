using MySqlConnector;
using System;
using System.Windows.Forms;

namespace McDo
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private readonly string connectionString =
            "server=localhost;user=root;password=Tantan#0119;database=mcdonalds_db;port=3306;";

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = rdoAdmin.Checked ? "admin" : "customer";

            LoginUser(username, password, role);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void LoginUser(string username, string password, string selectedRole)
        {
            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT password, role FROM users WHERE username = @username";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string dbPassword = reader.GetString("password"); // plain text
                    string dbRole = reader.GetString("role");

                    if (dbRole != selectedRole)
                    {
                        MessageBox.Show("Access denied.");
                        return;
                    }

                    // Direct plain text comparison
                    if (password == dbPassword)
                    {
                        MessageBox.Show("Login successful!");

                        if (dbRole == "admin")
                        {
                            new AdminForm().Show();
                        }
                        else
                        {
                            new CustomerForm().Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                }
                else
                {
                    MessageBox.Show("No user found with that username.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message);
            }
        }

        private void LogIn_Load_1(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void rdoCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signupForm = new SignUp();
            this.Close();
            signupForm.Show();
        }
    }
}
