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
}