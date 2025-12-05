using McDo.Database.Tables;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    //public DbSet<User> Users { get; set; } 
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = $"Server=localhost;Database={Environment.GetEnvironmentVariable("DB_FILE")};User=root;Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};";
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
