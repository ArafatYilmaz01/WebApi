using Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi.DataAccess
{
    public class LogContext: DbContext
    {
        public LogContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = LogDB; Trusted_Connection = False; MultipleActiveResultSets = true");
        }
        public LogContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Log> Logs { get; set; }
    }
}
