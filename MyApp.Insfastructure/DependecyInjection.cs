using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
using MyApp.Insfrastructure.Data;
using MyApp.Insfrastructure.Repositories;

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
            services.AddScoped<IEmployeeReository, EmployeeRepository>();
            return services;
        }
    }
}
