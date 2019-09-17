using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Signage.Service.Configuration;

namespace Signage.Service.Web.Host.Startup
{
    [DependsOn(
       typeof(ServiceWebCoreModule),
       typeof(ServiceInfoplayModule)
     )]
    public class ServiceWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ServiceWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServiceWebHostModule).GetAssembly());
        }
    }
}
