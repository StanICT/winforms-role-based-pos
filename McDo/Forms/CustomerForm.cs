using McDo.Database.Tables;
using McDo.Forms.CustomerForms;
using System.Drawing;
using System.Windows.Forms;

namespace McDo.Forms
{
    public partial class CustomerForm : Form
    {
        private List<Product> CartItems = new List<Product>();
        protected Category ActiveCategory = null!;
        private readonly McDoMain Main;

        public CustomerForm(McDoMain main)
        {
            Main = main;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            SetupProductList();
            LoadCategorySelectionSidebar();   // 🔧 load categories into sidebar
        }

        // Keep this only for the designer
        public CustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCategorySelectionSidebar();
        }

        private void SetupProductList()
        {
            Customer_ProductList.LargeImageList = new ImageList
            {
                ImageSize = new Size(64, 64),
                ColorDepth = ColorDepth.Depth32Bit
            };
            Customer_ProductList.View = View.LargeIcon;
        }

        private void LoadCategorySelectionSidebar(int active = 0)
        {
            Category_SelectionSidebar.Controls.Clear();

            var categories = Main.Products.GetAllCategories();

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

        private Button CreateCategoryButton(Category category)
        {
            var btn = new Button
            {
                Text = category.Name,
                Width = 140,
                Height = 40,
                Margin = new Padding(6)
            };
            btn.Click += (_, _) => SetActiveCategory(category);
            return btn;
        }

        private void SetActiveCategory(Category category)
        {
            ActiveCategory = category;

            Category_NameLabel.Text = category.Name;
            Category_DescriptionLabel.Text = category.Description;

            LoadCategoryProducts(category);
        }

        private void LoadCategoryProducts(Category category)
        {
            Customer_ProductList.Items.Clear();
            Customer_ProductList.LargeImageList.Images.Clear();

            foreach (var p in category.Products)
            {
                string key = $"{p.Name}_{p.Id}";
                Image img = p.IconImage ?? SystemIcons.Question.ToBitmap();
                Customer_ProductList.LargeImageList.Images.Add(key, img);

                var item = new ListViewItem
                {
                    Text = $"{p.Name} - ₱{p.Price:F2}", // show peso price
                    ImageKey = key,
                    Tag = p.Id
                };
                Customer_ProductList.Items.Add(item);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm();

            var products = new List<Product>();
            foreach (ListViewItem li in Customer_ProductList.SelectedItems)
            {
                int productId = (int)li.Tag;
                // ✅ FIX: use ActiveCategory.Products instead of ActiveProducts
                var product = ActiveCategory.Products.FirstOrDefault(p => p.Id == productId);
                if (product != null)
                    products.Add(product);
            }

            cartForm.LoadCart(products);
            cartForm.ShowDialog();
        }

        private void Customer_ProductList_DoubleClick(object sender, EventArgs e)
        {
            if (Customer_ProductList.SelectedItems.Count == 0) return;

            var item = Customer_ProductList.SelectedItems[0];
            int productId = (int)item.Tag;

            var product = ActiveCategory.Products.FirstOrDefault(p => p.Id == productId);

            if (product == null) return;

            var result = MessageBox.Show(
                $"Add {product.Name} to cart?",
                "Add to Cart",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                AddToCart(product);
            }
        }

        private void AddToCart(Product product)
        {
            CartItems.Add(product);
            MessageBox.Show($"{product.Name} added to cart!", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Customer_ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
