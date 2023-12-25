using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        // Fluent API
        builder.HasKey(e => e.Id); // Id, EmployeeId EF -> Core PK
        builder.Property(e => e.FirstName).IsRequired();
        builder.Property(e => e.LastName).IsRequired();

        builder.HasData(
            new Employee(){Id=1, FirstName="Ahmet", LastName = "Ağ", Salary=30_000, CompanyId=1},
            new Employee(){Id=2, FirstName="Mehmet", LastName = "Güneş", Salary=35_000, CompanyId=1},
            new Employee(){Id=3, FirstName="Filiz", LastName = "Irmak", Salary=39_000, CompanyId=2},
            new Employee(){Id=4, FirstName="Hatice", LastName = "Bulut", Salary=40_000, CompanyId=2},
            new Employee(){Id=5, FirstName="Can", LastName = "Deniz", Salary=45_000, CompanyId=3}
        );
    }
}