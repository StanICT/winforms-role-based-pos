namespace McDo.Modules.Product
{
    using Microsoft.EntityFrameworkCore;
    using CategoryShape = McDo.Database.Tables.Category;
    using ProductShape = McDo.Database.Tables.Product;

    public class ProductManager(AppDbContext context)
    {
        protected AppDbContext Context = context;

        public CategoryShape AddCategory(string name, string desc)
        {
            CategoryShape? category = GetCategory(name);
            if (category != null)
                return category;

            category = Context.Categories.Add(new CategoryShape()
            {
                Name = name,
                Description = desc,
            }).Entity;

            Context.SaveChanges();
            return category;
        }

        public CategoryShape? RemoveCategory(string name)
        {
            CategoryShape? category = GetCategory(name);
            if (category == null)
                return null;

            RemoveCategory(category);
            return category;
        }

        public bool RemoveCategory(CategoryShape category)
        {
            if (!Context.Categories.Contains(category))
                return false;

            Context.Categories.Remove(category);
            Context.Products.Where(p => p.CategoryId == category.Id).ExecuteDelete();

            Context.SaveChanges();

            return true;
        }

        public CategoryShape? GetCategory(string name)
        {
            return Context.Categories.Include(c => c.Products).FirstOrDefault(c => c.Name == name);
        }

        public List<CategoryShape> GetAllCategories()
        {
            return [.. Context.Categories.Include(c => c.Products).Cast<CategoryShape>()];
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

            ProductShape product = Context.Products.Add(new ProductShape()
            {
                Name = name,
                Description = desc,
                Price = price,
                Icon = icon,
                Category = category,
            }).Entity;

            Context.SaveChanges();
            return product;
        }

        public ProductShape? RemoveProduct(string categoryName, string name)
        {
            ProductShape? product = GetProduct(categoryName, name);
            product = product == null ? null : Context.Products.Remove(product).Entity;

            Context.SaveChanges();
            return product;
        }

        public ProductShape? RemoveProduct(CategoryShape category, string name)
        {
            ProductShape? product = GetProduct(category, name);
            product = product == null ? null : Context.Products.Remove(product).Entity;

            Context.SaveChanges();
            return product;
        }

        public ProductShape? GetProduct(string categoryName, string name)
        {
            return Context.Products.Include(p => p.Category).FirstOrDefault(p => p.Category.Name == categoryName && p.Name == name);
        }

        public ProductShape? GetProduct(CategoryShape category, string name)
        {
            return Context.Products.Include(p => p.Category).FirstOrDefault(p => p.CategoryId == category.Id && p.Name == name);
        }

        public List<ProductShape> GetAllProducts()
        {
            return [.. Context.Products.Include(p => p.Category).Cast<ProductShape>()];
        }
    }
}
