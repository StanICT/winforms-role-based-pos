using McDo.Database.Tables;
using McDo.Modules.Product;

namespace McDo.Forms.AdminForms.Products
{
    public struct ProductData(string name, double price, byte[] icon)
    {
        public string Name = name;
        public string? Description;
        public double Price = price;
        public byte[] Icon = icon;
    }

    public partial class ProductAdd : Form
    {
        protected ProductManager Products;
        protected Category ProductCategory;

        protected ProductData Data = new("", 0, []);
        protected Product? AddedProduct = null;

        public ProductAdd(ProductManager products, Category productCategory)
        {
            Products = products;
            ProductCategory = productCategory;

            InitializeComponent();

            Setup();
        }

        protected void Setup()
        {
            SetupIconReader();
        }

        protected void SetupIconReader()
        {
            Product_IconFileInput.Filter = "Images|*.png;*.jpg;*.jpeg;*.webp;*.bmp";
            Product_Icon.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public Product? GetAddedProduct()
        {
            return AddedProduct;
        }

        public bool Retrieve()
        {
            // Name
            Data.Name = Product_NameInput.Text;

            // Description
            Data.Description = Product_DescInput.Text;

            // Price
            if (!RetrievePrice())
            {
                Product_PriceInput.Focus();

                Product_PriceLabel.Text = "Invalid Price";
                Product_PriceLabel.ForeColor = Color.Red;

                return false;
            }

            // Icon
            RetrieveIcon(); // TODO: Validator if Icon will be required

            return true;
        }

        public bool RetrievePrice()
        {
            return double.TryParse(Product_PriceInput.Text, out Data.Price) && Data.Price > 0;
        }

        public bool RetrieveIcon()
        {
            using var stream = Product_IconFileInput.OpenFile();
            using var memstream = new MemoryStream();

            stream.CopyTo(memstream);
            Data.Icon = memstream.ToArray();

            return true;
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
        }

        private void Product_AddButton_Click(object sender, EventArgs e)
        {
            if (!Retrieve())
                return;

            AddedProduct = Products.AddProduct(ProductCategory, Data.Name, Data.Description ?? "", Data.Price, Data.Icon);
            this.DialogResult = DialogResult.OK;
        }

        private void Product_Icon_Click(object sender, EventArgs e)
        {
            var result = Product_IconFileInput.ShowDialog();
            if (result != DialogResult.OK)
                return;

            Product_Icon.Image?.Dispose();
            Product_Icon.Image = Image.FromFile(Product_IconFileInput.FileName);
        }
    }
}
