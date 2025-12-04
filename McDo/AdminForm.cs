using MySqlConnector;
using System.Data;

namespace McDo
{
    public partial class AdminForm : Form
    {
        private int selectedCategoryId = -1;
        private readonly string connectionString =
            "server=localhost;user=root;password=Tantan#0119;database=mcdonalds_db;port=3306;";


        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e) // Chicken
        {
            label1.Text = "Chicken and Platters";
        }

        private void button2_Click(object sender, EventArgs e) // Burgers
        {
            label1.Text = "Burgers";
        }

        private void button3_Click(object sender, EventArgs e) // Fries
        {
            label1.Text = "Fries";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Drinks and Desserts";
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
