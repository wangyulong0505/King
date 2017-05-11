using King.Configuration;
using King.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace King.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KingDbContextFactory : IDbContextFactory<KingDbContext>
    {
        public KingDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<KingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KingConsts.ConnectionStringName));
            
            return new KingDbContext(builder.Options);
        }
    }
}