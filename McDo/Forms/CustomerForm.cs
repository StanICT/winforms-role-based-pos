using McDo.Database.Tables;
using System.Drawing;
using System.Windows.Forms;

namespace McDo.Forms
{
    public partial class CustomerForm : Form
    {
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
            // optional: logo click handler
        }
    }
}
