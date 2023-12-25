using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.ProductId); // PK
        builder.Property(p => p.ProductName).IsRequired();

        builder.HasData(
            new Product(){ProductId=1, ProductName="HP Laptop", Price=27_000},
            new Product(){ProductId=2, ProductName="Kulaklık", Price=7_000},
            new Product(){ProductId=3, ProductName="Keyboard", Price=1_000}
        );
    }
}