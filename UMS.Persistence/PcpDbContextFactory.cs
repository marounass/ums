using Microsoft.EntityFrameworkCore;
using PCP.Persistence;
using PCP.Persistence.Infrastructure;

namespace UMS.Persistence
{
    public class PcpDbContextFactory 
        : DesignTimeDbContextFactoryBase<PostgresContext>
    {
        public override PostgresContext CreateNewInstance(DbContextOptions<PostgresContext> options)
        {
            return new PostgresContext(options);
        }
        
    }
}