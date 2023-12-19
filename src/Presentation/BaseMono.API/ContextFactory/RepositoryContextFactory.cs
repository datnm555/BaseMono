using BaseMono.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BaseMono.API.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        var builder =
            new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(config.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("BaseMono.API"));
        return new ApplicationDbContext(builder.Options);
    }
}