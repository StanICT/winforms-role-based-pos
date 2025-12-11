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

            Setup();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public AdminForm()
        {
            MessageBox.Show("AdminForm constructor start");
        }

        protected void Setup()
        {
            SetupCategoryPanel();
        }

        protected void SetupCategoryPanel()
        {
            Category_NameLabel.Text = "N/A";
            Category_DescriptionLabel.Text = "N/A";

            SetupProductList();
        }

        protected void SetupProductList()
        {
            Category_ProductList.LargeImageList = new()
            {
                ImageSize = new Size(64, 64),
            };
        }

        protected void LoadInitialCategory()
        {
            LoadCategorySelectionSidebar(0);
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadInitialCategory();
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

            Main.Products.RemoveCategory(ActiveCategory);
            LoadCategorySelectionSidebar();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void LoadCategorySelectionSidebar(int active = -1)
        {
            Category_SelectionSidebar.Controls.Clear();

            List<Category> categories = Main.Products.GetAllCategories();

            for (int i = 0; i < categories.Count; ++i)
            {
                var category = categories[i];
                var button = CreateCategoryButton(category);

                Category_SelectionSidebar.Controls.Add(button);

                if (i == active)
                {
                    SetActiveCategory(category);
                    button.Select();
                }
            }
        }

        private void LoadCategoryProducts(Category category)
        {
            var pList = Category_ProductList;
            var pListItems = pList.Items;

            pListItems.Clear();

            var images = pList.LargeImageList!.Images;
            images.Clear();

            category.Products.ForEach(p =>
            {
                string key = $"{p.Name}_{images.Count}";

                using (var memstream = new MemoryStream(p.Icon))
                    images.Add(key, Image.FromStream(memstream));

                ListViewItem item = new()
                {
                    Text = p.Name,
                    ImageKey = key,
                    Tag = p.Id,
                    //BackColor = Color.Goldenrod,
                };

                pListItems.Add(item);
            });
        }

        private Button CreateCategoryButton(Category category)
        {
            Button button = new()
            {
                Text = category.Name,
                Width = 129,
                Height = 40,
                //BackColor = Color.Goldenrod,
                Font = new Font("Helvetica", 9f, FontStyle.Regular),
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

        private void Category_ProductList_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = Category_ProductList.HitTest(e.Location);
            var item = hit.Item;

            if (item == null)
                return;

            Product? product = Main.Products.GetProduct((int)item.Tag!);
            if (product == null)
                return;

            var productManageForm = new ProductManage(Main.Products, product);
            var result = productManageForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            LoadCategoryProducts(ActiveCategory);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
