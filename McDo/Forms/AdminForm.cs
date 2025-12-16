using McDo.Database.Tables;
using McDo.Forms.AdminForms.Categories;
using McDo.Forms.AdminForms.Products;
using System.Drawing;
using System.IO;

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

        private static bool IsWebP(byte[]? data)
        {
            if (data == null || data.Length < 12) return false;
            // WebP files start with "RIFF" and have "WEBP" at bytes 8..11
            return data[0] == (byte)'R' && data[1] == (byte)'I' && data[2] == (byte)'F' && data[3] == (byte)'F'
                && data[8] == (byte)'W' && data[9] == (byte)'E' && data[10] == (byte)'B' && data[11] == (byte)'P';
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

                // Safely handle invalid or unsupported image bytes
                try
                {
                    if (p.Icon == null || p.Icon.Length == 0)
                    {
                        // fallback: use a default embedded resource image if available
                        images.Add(key, Properties.Resources.Untitled_design__1_);
                    }
                    else if (IsWebP(p.Icon))
                    {
                        // WebP isn't supported here; fallback to default
                        images.Add(key, Properties.Resources.Untitled_design__1_);
                    }
                    else
                    {
                        using (var memstream = new MemoryStream(p.Icon))
                        using (var img = Image.FromStream(memstream, true, true))
                        {
                            // create a detached copy so stream can be disposed
                            images.Add(key, new Bitmap(img));
                        }
                    }
                }
                catch (System.Exception)
                {
                    // If bytes are invalid or not a recognized image, add a default placeholder
                    try
                    {
                        images.Add(key, Properties.Resources.Untitled_design__1_);
                    }
                    catch
                    {
                        // last resort: add an empty 64x64 bitmap
                        images.Add(key, new Bitmap(64, 64));
                    }
                }

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
                Width = 140,
                Height = 40,
                Margin = new Padding(6),
                Font = new Font("Helvetica", 9f, FontStyle.Regular),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Standard
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

        private void Category_SelectionSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
