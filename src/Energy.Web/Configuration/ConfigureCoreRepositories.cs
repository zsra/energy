using Energy.Core.Interfaces.Repositories;
using Energy.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energy.Web.Configuration
{
    public static class ConfigureCoreRepositories
    {
        public static IServiceCollection AddCoreRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICatalogItemRepository, CatalogItemRepository>();
            return services;
        }


    }
}
