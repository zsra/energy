using Energy.Core.Interfaces.Repositories;
using Energy.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Energy.Web.Configurations
{
    public static class ConfigureCoreRepositories
    {
        public static IServiceCollection AddCoreRepositories(this IServiceCollection services
            , IConfiguration configuration)
        {
            services.AddScoped<ICatalogItemRepository, CatalogItemRepository>();
            return services;
        }
    }
}
