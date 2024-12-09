using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Toys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable("Toys");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Uppdaterad sökväg till din databas
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\maria\source\repos\HHL KOPIA\HenriksHobbyLager\HHLDatabas.db");
        }
    }
}









