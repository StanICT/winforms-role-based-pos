using McDo.Database.Tables;
using McDo.Modules.Product;

namespace McDo.Forms.AdminForms.Categories
{
    public partial class CategoryAdd : Form
    {
        protected ProductManager Products;
        protected Category? Category = null;

        public CategoryAdd(ProductManager products)
        {
            Products = products;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Category? GetAddedCategory()
        {
            return Category;
        }

        private void Category_AddButton_Click(object sender, EventArgs e)
        {
            string name = Category_NameInput.Text;
            string desc = Category_DescInput.Text;

            Category = Products.AddCategory(name, desc);

            this.DialogResult = DialogResult.OK;
        }
    }
}
