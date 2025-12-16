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

        // helper: create a detached bitmap copy in a safe pixel format
        private static Bitmap CreateCompatibleBitmap(Image src)
        {
            var bmp = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
            using var g = Graphics.FromImage(bmp);
            g.DrawImage(src, 0, 0, src.Width, src.Height);
            return bmp;
        }

        private static bool IsWebP(byte[] data)
        {
            if (data == null || data.Length < 12) return false;
            // WebP files start with "RIFF" and have "WEBP" at bytes 8..11
            return data[0] == (byte)'R' && data[1] == (byte)'I' && data[2] == (byte)'F' && data[3] == (byte)'F'
                && data[8] == (byte)'W' && data[9] == (byte)'E' && data[10] == (byte)'B' && data[11] == (byte)'P';
        }

        protected void SetupIconReader()
        {
            // webp isn't supported by System.Drawing on all platforms; exclude from filter
            Product_IconFileInput.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp";
            Product_Icon.SizeMode = PictureBoxSizeMode.Zoom;

            if (Product.Icon != null && Product.Icon.Length > 0)
            {
                try
                {
                    if (IsWebP(Product.Icon))
                    {
                        // cannot decode webp with System.Drawing safely
                        Product_Icon.Image?.Dispose();
                        Product_Icon.Image = null;
                        return;
                    }

                    // Use a MemoryStream so Image.FromStream gets a complete, seekable stream
                    using var memstream = new MemoryStream(Product.Icon);
                    using var img = Image.FromStream(memstream, true, true);
                    // create a detached copy to avoid keeping the underlying stream open
                    Product_Icon.Image?.Dispose();
                    Product_Icon.Image = CreateCompatibleBitmap(img);
                }
                catch (System.Exception)
                {
                    // If bytes are invalid or not a recognized image, fail gracefully
                    Product_Icon.Image?.Dispose();
                    Product_Icon.Image = null;
                }
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

            try
            {
                // make a compatible copy of the image and save the copy to a memory stream to avoid GDI+ errors
                using var bmp = CreateCompatibleBitmap(Product_Icon.Image);
                using var memstream = new MemoryStream();
                bmp.Save(memstream, ImageFormat.Png);
                TempData.Icon = memstream.ToArray();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to read icon: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TempData.Icon = null;
                return false;
            }
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
                Product.Icon = TempData.Icon;

            Products.Context.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void Product_Icon_Click(object sender, EventArgs e)
        {
            var result = Product_IconFileInput.ShowDialog();
            if (result != DialogResult.OK)
                return;

            // load image without locking the source file and create a detached copy
            try
            {
                // read all bytes first to avoid locking and ensure complete data
                var bytes = File.ReadAllBytes(Product_IconFileInput.FileName);

                if (IsWebP(bytes))
                {
                    MessageBox.Show("WebP images are not supported. Please use PNG or JPEG.", "Unsupported Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var memstream = new MemoryStream(bytes);
                using var img = Image.FromStream(memstream, true, true);

                Product_Icon.Image?.Dispose();
                Product_Icon.Image = CreateCompatibleBitmap(img);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
