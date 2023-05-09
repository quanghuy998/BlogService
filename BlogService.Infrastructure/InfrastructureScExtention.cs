using BlogService.Infrastructure.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BlogService.Infrastructure
{
    public static class InfrastructureScExtention
    {
        public static IServiceCollection AddInfrastructureServiceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseRegistration(configuration);
            return services;
        }
    }
}
