using McDo.Database.Tables;
using McDo.Forms.AdminForms.Categories;
using McDo.Forms.AdminForms.Products;

namespace McDo.Forms
{
    public partial class AdminForm : Form
    {
        private readonly McDoMain Main;

        protected Category ActiveCategory = null!;

        public AdminForm(McDoMain main)
        {
            Main = main;

            InitializeComponent();
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

            Category_SelectionSidebar.Controls.Add(CreateCategoryButton(categoryAddForm.GetAddedCategory()!));
        }

        private void Category_DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure that you wish to delete the '{ActiveCategory.Name}' category?\n\nNOTE: All of the products under this category will also be deleted.", "Delete Category", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            Main.Products.RemoveCategory(ActiveCategory.Name);
            LoadCategorySelectionSidebar();
        }

        private void Category_ProductAdd_Click(object sender, EventArgs e)
        {
            var productAddForm = new ProductAdd(Main.Products, ActiveCategory);
            var result = productAddForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            Product? p = productAddForm.GetAddedProduct();
            if (p != null)
                LoadCategoryProducts(ActiveCategory);
        }

        // UTILITY FUNCTIONS

        private void LoadCategorySelectionSidebar()
        {
            List<Category> categories = Main.Products.GetAllCategories();

            if (categories.Count != 0)
                SetActiveCategory(categories[0]);

            Category_SelectionSidebar.Controls.Clear();

            foreach (Category category in categories)
                Category_SelectionSidebar.Controls.Add(CreateCategoryButton(category));
        }

        private void LoadCategoryProducts(Category category)
        {
            Category_ProductList.Items.Clear();

            category.Products.ForEach(p =>
            {
                ListViewItem item = new()
                {
                    Text = $"{p.Name}\nPhp{p.Price}",
                    ToolTipText = $"{p.Name} [Php{p.Price}]\n{p.Description}",
                };

                Category_ProductList.Items.Add(item);
            });
        }

        private Button CreateCategoryButton(Category category)
        {
            Button button = new()
            {
                Text = category.Name,
                Width = 100,
                Height = 40,
                //BackColor = Color.Goldenrod,
                //Font = new Font("Helvetica", 9.0, FontStyle.Regular),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(5),
            };

            button.Click += (s, e) =>
            {
                SetActiveCategory(category);
            };

            return button;
        }

        private void SetActiveCategory(Category category)
        {
            ActiveCategory = category;

            Category_NameLabel.Text = category.Name;
            Category_DescriptionLabel.Text = category.Description;

            // Load Products of the Category
            LoadCategoryProducts(category);
        }
    }
}
