using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependecyInjection).Assembly));
            return services;
        }
    }
}
