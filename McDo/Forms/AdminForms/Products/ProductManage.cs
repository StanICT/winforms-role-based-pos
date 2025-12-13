using McDo.Database.Tables;
using McDo.Modules.Product;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace McDo.Forms.AdminForms.Products
{
    public partial class ProductManage : Form
    {
        protected ProductManager Products;
        protected Product Product;
        protected ProductData TempData = new ProductData();

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

            if (Product.Icon != null && Product.Icon.Length > 0)
            {
                using var memstream = new MemoryStream(Product.Icon);
                Product_Icon.Image = Image.FromStream(memstream);
            }
            else
            {
                Product_Icon.Image = null;
            }
        }

        public Product GetProduct()
        {
            return Product;
        }

        public bool Retrieve()
        {
            TempData.Name = Product_NameInput.Text;
            TempData.Description = Product_DescInput.Text;

            if (!RetrievePrice())
            {
                Product_PriceInput.Focus();
                Product_PriceLabel.Text = "Invalid Price";
                Product_PriceLabel.ForeColor = Color.Red;
                return false;
            }

            RetrieveIcon();
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
            if (Product_Icon.Image == null)
            {
                TempData.Icon = null;
                return false;
            }

            using var memstream = new MemoryStream();
            Product_Icon.Image.Save(memstream, System.Drawing.Imaging.ImageFormat.Png);
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

            if (TempData.Icon != null)
                Product.Icon = TempData.Icon; // only update if new icon chosen

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
            var result = MessageBox.Show(
                $"Are you sure that you wish to delete the '{Product.Name}' product?",
                "Delete Product",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            Products.RemoveProduct(Product.Id);
            this.DialogResult = DialogResult.OK;
        }
    }
}
