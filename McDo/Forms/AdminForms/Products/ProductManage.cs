using McDo.Database.Tables;
using McDo.Modules.Product;

namespace McDo.Forms.AdminForms.Products
{
    public partial class ProductManage : Form
    {
        protected ProductManager Products;
        protected Product Product;

        protected ProductData TempData;

        public ProductManage(ProductManager products, Product product)
        {
            Products = products;
            Product = product;

            InitializeComponent();

            Setup();
        }

        protected void Setup()
        {
            SetupInputs();
        }

        protected void SetupInputs()
        {
            Product_NameInput.Text = Product.Name;
            Product_DescInput.Text = Product.Description;

            Product_PriceInput.Text = Product.Price.ToString();

            SetupIconReader();
        }

        protected void SetupIconReader()
        {
            Product_IconFileInput.Filter = "Images|*.png;*.jpg;*.jpeg;*.webp;*.bmp";
            Product_Icon.SizeMode = PictureBoxSizeMode.Zoom;

            using var memstream = new MemoryStream(Product.Icon);
            Product_Icon.Image = Image.FromStream(memstream);
        }

        public Product GetProduct()
        {
            return Product;
        }

        public bool Retrieve()
        {
            // Name
            TempData.Name = Product_NameInput.Text;

            // Description
            TempData.Description = Product_DescInput.Text;

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
            var valid = double.TryParse(Product_PriceInput.Text, out double price) && price > 0;
            if (valid)
                TempData.Price = price;

            return valid;
        }

        public bool RetrieveIcon()
        {
            var image = Product_Icon.Image;
            if (image == null)
                return false;

            using var memstream = new MemoryStream();
            image.Save(memstream, image.RawFormat);

            TempData.Icon = memstream.ToArray();

            return true;
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
        }

        private void Product_EditButton_Click(object sender, EventArgs e)
        {
            if (!Retrieve())
                return;

            Product.Name = TempData.Name;
            Product.Description = TempData.Description;
            Product.Price = TempData.Price;
            Product.Icon = TempData.Icon;

            Products.Context.SaveChanges();

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

        private void Product_DeleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            var result = MessageBox.Show($"Are you sure that you wish to delete the '{Product.Name}' product?", "Delete Product", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            Products.RemoveProduct(Product.Id);
        }
    }
}
