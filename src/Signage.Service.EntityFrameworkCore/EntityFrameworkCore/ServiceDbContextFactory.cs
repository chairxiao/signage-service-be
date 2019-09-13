using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Signage.Service.Configuration;
using Signage.Service.Web;

namespace Signage.Service.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ServiceDbContextFactory : IDesignTimeDbContextFactory<ServiceDbContext>
    {
        public ServiceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ServiceDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ServiceDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ServiceConsts.ConnectionStringName));

            return new ServiceDbContext(builder.Options);
        }
    }
}
