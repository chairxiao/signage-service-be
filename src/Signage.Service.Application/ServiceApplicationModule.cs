using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Signage.Service.Authorization;

namespace Signage.Service
{
    [DependsOn(
        typeof(ServiceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ServiceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ServiceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ServiceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
