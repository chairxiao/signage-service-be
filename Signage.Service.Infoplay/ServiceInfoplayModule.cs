using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service
{
    [DependsOn(
     typeof(ServiceWebCoreModule))]
    public class ServiceInfoplayModule : AbpModule
    {

        
        public override void PreInitialize()
        {
            IocManager.Register<IBackgroundWorkerManager, BackgroundWorkerManager>();
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServiceInfoplayModule).GetAssembly());
        }
        public override void PostInitialize()
        {

            //注册后台工作者
            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<FileDownloadService>());
            workManager.Add(IocManager.Resolve<DownloadService>());
        }
    }
}
