using Microsoft.EntityFrameworkCore;
using Repositories;

namespace LibraryApi.Services;

public static class ConnectionString
{
    public static void SetConnectionString(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDbContext<RepositoryContext>(options =>
        {
            options.UseSqlite(builder.Configuration.GetConnectionString("sqlite"),
            prj => prj.MigrationsAssembly("LibraryApi"));
        });
    }
}