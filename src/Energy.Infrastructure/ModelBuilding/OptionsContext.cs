using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Net;

namespace Energy.Infrastructure.ModelBuilding
{
    public class OptionsContext : DbContext
    {
        #region Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseCosmos(
                ConfigurationManager.AppSettings["PrimaryCOnnectionString"],
                databaseName: ConfigurationManager.AppSettings["OptionDatabaseName"],
                options =>
                {
                    options.ConnectionMode(ConnectionMode.Gateway);
                    options.WebProxy(new WebProxy());
                    options.LimitToEndpoint();
                    options.Region(Regions.WestEurope);
                    options.GatewayModeMaxConnectionLimit(32);
                    options.MaxRequestsPerTcpConnection(8);
                    options.MaxTcpConnectionsPerEndpoint(16);
                    options.IdleTcpConnectionTimeout(TimeSpan.FromMinutes(1));
                    options.OpenTcpConnectionTimeout(TimeSpan.FromMinutes(1));
                    options.RequestTimeout(TimeSpan.FromMinutes(1));
                });
        #endregion
    }
}
