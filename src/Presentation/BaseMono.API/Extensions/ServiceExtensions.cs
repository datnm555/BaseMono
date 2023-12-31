﻿using BaseMono.LoggerService.Manager;
using BaseMono.Repository;
using BaseMono.Repository.Abstraction;
using BaseMono.Service.Contracts;
using BaseMono.Services;
using Microsoft.EntityFrameworkCore;

namespace BaseMono.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        });
    }

    public static void ConfigureIisIntegration(this IServiceCollection serviceCollection)
    {
        serviceCollection.Configure<IISOptions>(options => { });
    }

    public static void ConfigureLoggerService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ILoggerManager, LoggerManager>();
    }

    public static void ConfigureRepositoryManager(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IRepositoryManager, RepositoryManager>();
    }

    public static void ConfigureServiceManager(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IServiceManager, ServiceManager>();
    }

    public static void ConfigureSqlContext(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(builder =>
        {
            builder.UseSqlServer(
                configuration.GetConnectionString("sqlConnection"),
                optionsBuilder => optionsBuilder.MigrationsAssembly("BaseMono.API"));
        });
    }
}