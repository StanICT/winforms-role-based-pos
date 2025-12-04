namespace McDo
{
    public partial class McDo : Form
    {
        public McDo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new LoginOrSignup();
            this.Hide(); // closes Form1 so it doesn't keep the process runnin
            f2.Show();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
