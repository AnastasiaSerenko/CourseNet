using Microsoft.EntityFrameworkCore;
using OnlineCafe.DB;

namespace OnlineCafe.API;

public static class Startup
{
    public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}
