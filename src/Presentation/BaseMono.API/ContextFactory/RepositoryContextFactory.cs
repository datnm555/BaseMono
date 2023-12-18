﻿using BaseMono.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BaseMono.API.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        var builder =
            new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(config.GetConnectionString("sqlConnection"));
        return new RepositoryContext(builder.Options);
    }
}