using Microsoft.EntityFrameworkCore;

namespace Traversal.SignalRApiForSql.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
