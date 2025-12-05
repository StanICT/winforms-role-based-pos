using McDo.Database.Tables;
using McDo.Forms.AdminForms.Categories;

namespace McDo.Forms
{
    public partial class AdminForm : Form
    {
        private readonly McDoMain Main;
        private int selectedCategoryId = 0;

        public AdminForm(McDoMain main)
        {
            Main = main;

            InitializeComponent();
        }

        private void LoadCategoryPanel(string categoryName)
        {
            Category_NameLabel.Text = categoryName;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadCategorySelectionSidebar();
        }

        private void Category_Add_Click(object sender, EventArgs e)
        {
            var categoryAddForm = new CategoryAdd(Main.Products);
            var result = categoryAddForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            var button = CreateCategoryButton(categoryAddForm.GetAddedCategory()!);
            button.Width = Category_SelectionSidebar.Width;

            Category_SelectionSidebar.Controls.Add(button);
        }

        // UTILITY FUNCTIONS

        private void LoadCategorySelectionSidebar()
        {
            List<Category> categories = Main.Products.GetAllCategories();

            foreach (Category category in categories)
            {
                var button = CreateCategoryButton(category);
                button.Width = Category_SelectionSidebar.Width;

                Category_SelectionSidebar.Controls.Add(button);
            }

            //Category_SelectionSidebar.Refresh();
        }

        private static Button CreateCategoryButton(Category category)
        {
            Button button = new()
            {
                Text = category.Name,
                Width = 120,
                Height = 40,
                //BackColor = Color.Goldenrod,
                //Font = new Font("Helvetica", 9.0, FontStyle.Regular),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(5),
            };

            button.Click += (s, e) =>
            {
                MessageBox.Show(category.Name);
            };

            return button;
        }
    }
}
