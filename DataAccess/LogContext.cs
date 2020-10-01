using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class LogContext: DbContext
    {
        public LogContext(DbContextOptions options)
            : base(options)
        { }
        public DbSet<Log> Logs { get; set; }
    }
}
