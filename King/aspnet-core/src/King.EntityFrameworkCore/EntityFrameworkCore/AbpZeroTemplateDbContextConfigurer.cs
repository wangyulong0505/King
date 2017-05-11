using Microsoft.EntityFrameworkCore;

namespace King.EntityFrameworkCore
{
    public static class KingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}