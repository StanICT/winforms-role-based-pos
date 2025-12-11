namespace McDo.Modules.Product
{
    using Microsoft.EntityFrameworkCore;
    using CategoryShape = McDo.Database.Tables.Category;
    using ProductShape = McDo.Database.Tables.Product;

    public class ProductManager(AppDbContext context)
    {
        protected AppDbContext Context_ = context;

        public AppDbContext Context { get => Context_; }

        public CategoryShape AddCategory(string name, string desc)
        {
            CategoryShape? category = GetCategory(name);
            if (category != null)
                return category;

            category = Context_.Categories.Add(new CategoryShape()
            {
                Name = name,
                Description = desc,
            }).Entity;

            Context_.SaveChanges();
            return category;
        }

        public CategoryShape? RemoveCategory(string name)
        {
            CategoryShape? category = GetCategory(name);
            if (category == null)
                return null;

            Context_.Categories.Remove(category);
            Context_.SaveChanges();

            return category;
        }

        public bool RemoveCategory(CategoryShape category)
        {
            CategoryShape? actual = Context_.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (actual == null)
                return false;

            Context_.Categories.Remove(actual);
            Context_.SaveChanges();

            return true;
        }

        public CategoryShape? GetCategory(string name)
        {
            return Context_.Categories.Include(c => c.Products).FirstOrDefault(c => c.Name == name);
        }

        public List<CategoryShape> GetAllCategories()
        {
            return [.. Context_.Categories.Include(c => c.Products).Cast<CategoryShape>()];
        }

        public ProductShape? AddProduct(string categoryName, string name, string desc, double price, byte[] icon)
        {
            CategoryShape? category = GetCategory(categoryName);
            return category == null ? null : AddProduct(category, name, desc, price, icon);
        }

        public ProductShape? AddProduct(CategoryShape category, string name, string desc, double price, byte[] icon)
        {
            if (category == null)
                return null;

            ProductShape product = Context_.Products.Add(new ProductShape()
            {
                Name = name,
                Description = desc,
                Price = price,
                Icon = icon,
                Category = category,
            }).Entity;

            Context_.SaveChanges();
            return product;
        }

        public ProductShape? RemoveProduct(int id)
        {
            ProductShape? product = GetProduct(id);
            product = product == null ? null : Context_.Products.Remove(product).Entity;

            Context_.SaveChanges();
            return product;
        }

        public ProductShape? RemoveProduct(string categoryName, string name)
        {
            ProductShape? product = GetProduct(categoryName, name);
            product = product == null ? null : Context_.Products.Remove(product).Entity;

            Context_.SaveChanges();
            return product;
        }

        public ProductShape? RemoveProduct(CategoryShape category, string name)
        {
            ProductShape? product = GetProduct(category, name);
            product = product == null ? null : Context_.Products.Remove(product).Entity;

            Context_.SaveChanges();
            return product;
        }

        public ProductShape? GetProduct(int id)
        {
            return Context_.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

        public ProductShape? GetProduct(string categoryName, string name)
        {
            return Context_.Products.Include(p => p.Category).FirstOrDefault(p => p.Category.Name == categoryName && p.Name == name);
        }

        public ProductShape? GetProduct(CategoryShape category, string name)
        {
            return Context_.Products.Include(p => p.Category).FirstOrDefault(p => p.CategoryId == category.Id && p.Name == name);
        }

        public List<ProductShape> GetAllProducts()
        {
            return [.. Context_.Products.Include(p => p.Category).Cast<ProductShape>()];
        }
    }
}
