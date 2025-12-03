using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace McDo
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = txtPassword.Text;
            string role = radioButton1.Checked ? "admin" : "customer";

            LoginUser(textBox1.Text, txtPassword.Text, role);

            // Fix: Pass 'role' with 'out' keyword as required by ValidateLogin signature
            ValidateLogin(username, password, out role);
        }

        // New: toggles password char visibility from a checkbox (matches SignUp.cs behavior)
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1.Checked;
            txtPassword.UseSystemPasswordChar = !show;
        }


        // 👇 PASTE LOGIN METHOD HERE (inside class)
        private readonly string connectionString =
    "server=localhost;user=root;password=Tantan#0119;database=mcdonalds_db;port=3306;";

        public void LoginUser(string name, string password, string role)
        {
            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT password, role FROM users WHERE name=@name LIMIT 1;";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string dbHash = reader.GetString("password");
                    string dbRole = reader.GetString("role");

                    if (dbRole != role)
                    {
                        MessageBox.Show("Access denied. The selected role does not match the registered user role.");
                        return;
                    }

                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, dbHash);
                    if (isPasswordCorrect)
                    {
                        MessageBox.Show("Login successful. Credentials have been validated.");
                    }
                    else
                    {
                        MessageBox.Show("Login failed. The password entered is incorrect.");
                    }
                }
                else
                {
                    MessageBox.Show("Login failed. No user record was found with the provided username.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("A database error occurred while attempting to log in.\nError details: " + ex.Message);
            }
        }
        private bool ValidateLogin(string username, string password, out string role)
        {
            role = "";
            string connectionString = "server=localhost;user id=root;password=yourpassword;database=userdb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT role FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = reader["role"].ToString();
                    return true;
                }
                return false;
            }
        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
