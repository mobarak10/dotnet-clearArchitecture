using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Insfrastructure.Data;

namespace MyApp.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInsfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(
                    "Server=localhost;Database=MyAppDb;User=root;Password=;",
                    ServerVersion.Create(8, 0, 30, Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MySql)
                );
            });
            return services;
        }
    }
}
