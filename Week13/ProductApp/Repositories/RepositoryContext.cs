using System.Reflection;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // modelBuilder.Entity<Product>()
        //     .HasData();
        // modelBuilder.ApplyConfiguration(new ProductConfig());
        // modelBuilder.ApplyConfiguration(new CommentConfig());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}