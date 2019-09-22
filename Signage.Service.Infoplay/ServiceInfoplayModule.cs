

using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Signage.Service.Configuration;
using Signage.Service.Infoplay;

namespace Signage.Service
{

    public class ServiceInfoplayModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ServiceInfoplayModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }
        public override void PreInitialize()
        {
            IocManager.Register<IBackgroundWorkerManager, BackgroundWorkerManager>();

            IocManager.Register<InfoplayConfig>();
            var infoplayConfig = IocManager.Resolve<InfoplayConfig>();
            _appConfiguration.GetSection("InfoplayConfig").Bind(infoplayConfig);


            IocManager.Register<DownloadServiceConfig>();
            var downloadServiceConfig = IocManager.Resolve<DownloadServiceConfig>();
            _appConfiguration.GetSection("DownloadServiceConfig").Bind(downloadServiceConfig);
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServiceInfoplayModule).GetAssembly());
        }
        public override void PostInitialize()
        {
            //注册后台工作者
            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<DownloadWorker>());
        }
    }
}
