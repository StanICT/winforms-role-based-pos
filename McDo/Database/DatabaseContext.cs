using McDo.Database.Tables;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    //public DbSet<User> Users { get; set; } 
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = "Data Source=__mcdonalds_storage__";
        options.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
