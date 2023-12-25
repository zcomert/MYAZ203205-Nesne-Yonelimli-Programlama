using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class CompanyConfig : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey( c => c.CompanyId);
        builder.Property(c => c.CompanyName).IsRequired();

        builder.HasData(
            new Company(){CompanyId=1, CompanyName="Turkcell", WebSite="www.turkcell.com"},
            new Company(){CompanyId=2, CompanyName="Samsun Üniversitesi", WebSite="www.samsun.edu.tr"},
            new Company(){CompanyId=3, CompanyName="Aselsan", WebSite="www.aselsan.com"}
        );
    }
}