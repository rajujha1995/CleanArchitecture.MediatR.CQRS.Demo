namespace Dot7.Architecture.Infrastructure;

public static class RegisterService
{
    public static void ConfigureInfraStructure(this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddDbContext<CQRSDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("CQRSDbContextConnectionStrings"));
        });
        services.AddScoped<ICQRSDbContext>(option =>
        {
            return option.GetService<CQRSDbContext>();
        });
    }
}