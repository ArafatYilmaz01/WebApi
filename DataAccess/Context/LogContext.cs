using Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi.DataAccess
{
    public class LogContext: DbContext
    {
        public LogContext()
        {
        }

        public LogContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Log> Logs { get; set; }
    }
}
