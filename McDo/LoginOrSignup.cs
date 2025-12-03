using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace McDo
{
    public partial class LoginOrSignup : Form
    {
        public LoginOrSignup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            var signupForm = new SignUp();
            this.Close();
            signupForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var McDoForm = new McDo();
            this.Close();
            McDoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loggingIn = new LogIn();
            this.Close();
            loggingIn.Show();
        }
        private DatabaseHelper db = new DatabaseHelper();

        public void RegisterUser(string name, string password, string confirmPassword, string role)
        {
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords don't match bestie 😭");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using var conn = db.GetConnection();
            conn.Open();

            string query = "INSERT INTO users (name, password, role) VALUES (@name,@pass,@role)";
            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", hashedPassword);
            cmd.Parameters.AddWithValue("@role", role);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered successfully, you're cooking 🔥");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Username already exist bruh 💀");
                else
                    MessageBox.Show("DB Error: " + ex.Message);
            }
        }
        public void LoginUser(string name, string password, string role)
        {
            using var conn = db.GetConnection();
            conn.Open();

            string query = "SELECT password, role FROM users WHERE name=@name LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", name);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string dbPass = reader.GetString("password");
                string dbRole = reader.GetString("role");

                if (dbRole != role)
                {
                    MessageBox.Show("Role mismatch, choose the right lane frfr 🧍‍♂️🧍‍♀️");
                    return;
                }

                if (BCrypt.Net.BCrypt.Verify(password, dbPass))
                {
                    MessageBox.Show($"Login success, welcome {dbRole} slayyyy ✨");

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
                    MessageBox.Show("Wrong password bestie 🫠");
                }
            }
            else
            {
                MessageBox.Show("User not found!!");
            }
        }


    }
}
