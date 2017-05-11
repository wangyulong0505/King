using Abp.Zero.EntityFrameworkCore;
using King.Authorization.Roles;
using King.Authorization.Users;
using King.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace King.EntityFrameworkCore
{
    public class KingDbContext : AbpZeroDbContext<Tenant, Role, User, KingDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public KingDbContext(DbContextOptions<KingDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //...
        }
    }
}
