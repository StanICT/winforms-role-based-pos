using Microsoft.Data.SqlClient;
using MySqlConnector;
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
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string role = "";
            if (radioButton1.Checked)
                role = "admin";
            else if (radioButton2.Checked)
                role = "customer";
            else
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=Tantan#0119;database=mcdonalds_db"))
            {
                conn.Open();
                string query = "INSERT INTO users (username, password, role) VALUES (@user, @pass, @role)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text); // later use hashing
                cmd.Parameters.AddWithValue("@role", role);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Signup successful!");
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

    }
}
