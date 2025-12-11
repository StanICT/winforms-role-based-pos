using McDo.Forms;
using MySqlConnector;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace McDo.Setup
{
    public partial class AdminLogin : Form
    {
        private readonly string connectionString =
            "server=localhost;user=root;password=Tantan#0119;database=mcdonalds_db;port=3306;";

        public AdminLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPassword.UseSystemPasswordChar = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Configuration_Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both name and password.");
                return;
            }

            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT COUNT(*) FROM admin_users WHERE username = @user AND password = @pass";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int matchCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (matchCount > 0)
                {
                    // Save session to AppData like the configuration flow
                    string folder = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        "McDoPOS"
                    );

                    Directory.CreateDirectory(folder);
                    string path = Path.Combine(folder, "session.json");

                    var session = new UserSession { UserType = "Admin" };
                    string json = JsonSerializer.Serialize(session);
                    File.WriteAllText(path, json);

                    MessageBox.Show("Login successful!");

                    // Signal success to the caller instead of creating forms here
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadCategoriesFromDatabase()
        {
            // No-op: Method stub to resolve missing method error.
            // Implement logic here if needed, or remove the call if not required.
        }
    }

    public class UserSession
    {
        public string UserType { get; set; }
    }
}
