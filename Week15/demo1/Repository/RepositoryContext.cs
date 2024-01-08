using demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace demo1.Repository;

public class RepositoryContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Phone> Phones { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = demo.db;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().HasData(
            new Company() { CompanyId = 1, Name = "Apple", Country = "USA" },
            new Company() { CompanyId = 2, Name = "Samsung", Country = "USA" },
            new Company() { CompanyId = 3, Name = "Huawei", Country = "China" }
        );

        modelBuilder.Entity<Phone>().HasData(
            new Phone() { 
                Id = 1, 
                Model = "iPhone 14 Pro", 
                Size = 10.2, 
                Price = 1000, 
                Color = "Red", 
                CompanyId = 1
            },
            new Phone() {
                Id = 2, 
                Model = "S20", 
                Size = 9, 
                Price = 1200, 
                Color = "Black", 
                CompanyId = 2
            },
            new Phone() {
                Id = 3, 
                Model = "F60", 
                Size = 7, 
                Price = 900, 
                Color = "Black", 
                CompanyId = 3
            });
  
        base.OnModelCreating(modelBuilder);
    }
}