using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace McDo
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginOrSignup = new LoginOrSignup();
            this.Close();
            loginOrSignup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loginOrSignup = new LoginOrSignup();
            this.Close();
            loginOrSignup.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SigningIn_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string role = radioButton1.Checked ? "admin" : "customer";
            RegisterUser(txtName.Text, txtPassword.Text, txtConfirmPassword.Text, role);

            string selectedRole = "";

            if (radioButton1.Checked)
                selectedRole = "Admin";
            else if (radioButton2.Checked)
                selectedRole = "Customer";
            else
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            RegisterUser(txtName.Text, txtName.Text, txtPassword.Text, selectedRole);
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string connectionString = "server=localhost;user id=root;password=Tantan#0119;database=mcdonalds_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected to MySQL!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }

            var loggingIn = new LogIn();
            this.Close();
            loggingIn.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1?.Checked ?? false;

            if (txtPassword != null)
                txtPassword.UseSystemPasswordChar = !show;
            if (txtConfirmPassword != null)
                txtConfirmPassword.UseSystemPasswordChar = !show;
        }



        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void RegisterUser(string name, string username, string password, string role)
        {
            string connectionString = "server=localhost;user id=root;password=yourpassword;database=userdb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO users (name, username, password, role) VALUES (@name, @username, @password, @role)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
