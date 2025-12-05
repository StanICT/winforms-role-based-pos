namespace McDo.Forms
{
    public partial class AdminForm : Form
    {
        private int selectedCategoryId = -1;

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter new category name:", "Add Category", "");

            if (string.IsNullOrWhiteSpace(newCategory)) return;

            Button catButton = new Button();
            catButton.Text = newCategory;

            catButton.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catButton.Size = new Size(129, 39);
            catButton.UseVisualStyleBackColor = true;
            catButton.Click += (s, ev) => LoadCategoryPanel(newCategory);

            flowSidebar.Controls.Add(catButton);
        }


        private void CreateCategoryButton(string categoryName)
        {
            Button catButton = new Button();
            catButton.Text = categoryName;
            catButton.Width = 120;
            catButton.Height = 40;
            catButton.BackColor = Color.Goldenrod;
            catButton.ForeColor = Color.White;
            catButton.FlatStyle = FlatStyle.Flat;
            catButton.Margin = new Padding(5);
            catButton.Click += (s, e) => LoadCategoryPanel(categoryName);

            flowSidebar.Controls.Add(catButton);
            catButton.Click += (s, e) =>
            {
                label1.Text = categoryName;
                LoadCategoryPanel(categoryName);
            };

        }
        private void LoadCategoryPanel(string categoryName)
        {
            label1.Text = categoryName;
        }

    }
}
