using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Signage.Service.EntityFrameworkCore.Seed;

namespace Signage.Service.EntityFrameworkCore
{
    [DependsOn(
        typeof(ServiceCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ServiceEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            // add this line to disable transactions for sqlite
            Configuration.UnitOfWork.IsTransactional = false;

            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ServiceDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ServiceDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ServiceDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServiceEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
