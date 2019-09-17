using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Signage.Service.EntityFrameworkCore
{
    public static class ServiceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ServiceDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseSqlite(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ServiceDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseSqlite(connection);
        }
    }
}
