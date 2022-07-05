using Microsoft.EntityFrameworkCore;
using OnlineCafe.Entities;

namespace OnlineCafe.DB;

public class AppDbContext : DbContext
{
    public DbSet<Table> Tables { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<MenuIngredient> MenuIngredients { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    public AppDbContext() => Database.EnsureCreated();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MenuIngredient>().HasKey(x => new { x.MenuId, x.IngredientId });
        base.OnModelCreating(modelBuilder);
    }
}
