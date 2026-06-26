using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infrastructure;

public class ProductClientHubDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = default!; //garante que não vai ser nulo.
    public DbSet<Product> Products { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\guilh\\Downloads\\ProductClientHub.db");
    }
}
