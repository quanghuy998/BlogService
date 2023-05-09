using BlogService.Domain.Aggregates.Roles;
using BlogService.Domain.Aggregates.UserRoles;
using BlogService.Domain.Aggregates.Users;
using BlogService.Domain.SeedWork;
using BlogService.Infrastructure.Database;
using BlogService.Infrastructure.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogService.Infrastructure.Domain
{
    internal static class DomainSCExtension
    {
        public static IServiceCollection AddDatabaseRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuthDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("IdentityService"));
            });

            services.AddScoped<IUnitOfWork>(scope => new UnitOfWork(scope.GetService<AuthDbContext>()));
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();

            return services;
        }
    }
}
