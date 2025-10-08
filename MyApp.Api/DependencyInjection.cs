using MyApp.Application;
namespace MyApp.Api
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInsfrastructureDI();
            return services;
        }
    }
}
