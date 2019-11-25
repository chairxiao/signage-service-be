using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Signage.Service.Authorization.Roles;
using Signage.Service.Authorization.Users;
using Signage.Service.MultiTenancy;
using Signage.Service.Programs.ProgramType;

namespace Signage.Service.EntityFrameworkCore
{
    public class ServiceDbContext : AbpZeroDbContext<Tenant, Role, User, ServiceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProgramType> ProgramTypes { get; set; }
            
    }
}
