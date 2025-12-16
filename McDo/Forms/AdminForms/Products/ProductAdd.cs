using McDo.Database.Tables;
using McDo.Modules.Product;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace McDo.Forms.AdminForms.Products
{
    public struct ProductData
    {
        public string Name;
        public string? Description;
        public double Price;
        public byte[]? Icon;

        public ProductData(string name, double price, byte[]? icon)
        {
            Name = name;
            Description = null;
            Price = price;
            Icon = icon;
        }
    }

    public partial class ProductAdd : Form
    {
        protected ProductManager Products;
        protected Category ProductCategory;

        protected ProductData Data = new("", 0, null);
        protected Product? AddedProduct = null;

        public ProductAdd(ProductManager products, Category productCategory)
        {

            Products = products;
            ProductCategory = productCategory;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            Data.Name = Product_NameInput.Text;
            Data.Description = Product_DescInput.Text;

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
            return double.TryParse(Product_PriceInput.Text, out Data.Price) && Data.Price > 0;
        }

        public bool RetrieveIcon()
        {
            if (Product_Icon.Image == null)
            {
                Data.Icon = null;
                return false;
            }

            try
            {
                using var memstream = new MemoryStream();
                Product_Icon.Image.Save(memstream, System.Drawing.Imaging.ImageFormat.Png);
                Data.Icon = memstream.ToArray();

                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to retrieve icon: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Data.Icon = null;
                return false;
            }
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
        }

        private void Product_AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Retrieve())
                    return;

                AddedProduct = Products.AddProduct(
                    ProductCategory,
                    Data.Name,
                    Data.Description ?? "",
                    Data.Price,
                    Data.Icon ?? Array.Empty<byte>()
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Product_Icon_Click(object sender, System.EventArgs e)
        {
            var result = Product_IconFileInput.ShowDialog();
            if (result != DialogResult.OK)
                return;

            try
            {
                using var fs = File.OpenRead(Product_IconFileInput.FileName);
                using var img = Image.FromStream(fs);
                Product_Icon.Image?.Dispose();
                Product_Icon.Image = new Bitmap(img);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}\n{ex}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
