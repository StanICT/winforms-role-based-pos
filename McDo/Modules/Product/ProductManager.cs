namespace McDo.Modules.Product
{
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
            category = category == null ? null : Context.Categories.Remove(category).Entity;

            Context.SaveChanges();
            return category;
        }

        public CategoryShape? GetCategory(string name)
        {
            return Context.Categories.FirstOrDefault(c => c.Name == name);
        }

        public List<CategoryShape> GetAllCategories()
        {
            return [.. Context.Categories.Cast<CategoryShape>()];
        }

        public ProductShape? AddProduct(string categoryName, string name, string desc, double price)
        {
            CategoryShape? category = GetCategory(categoryName);
            ProductShape? product = category == null ? null : Context.Products.Add(new ProductShape()
            {
                Name = name,
                Description = desc,
                Price = price,
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

        public ProductShape? GetProduct(string categoryName, string name)
        {
            return Context.Products.FirstOrDefault(p => p.Category.Name == categoryName && p.Name == name);
        }

        public List<ProductShape> GetAllProducts()
        {
            return [.. Context.Products.Cast<ProductShape>()];
        }

        public void LoadCategory()
        {

        }
    }
}
