using WebApi.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WebApi.DataAccess;

namespace Core.DataAccess
{
	public class LogRepository<T> : BaseRepository<T> where T : class
	{
		protected WebApi.DataAccess.LogContext _context;
		private DbSet<T> _dbSet;
		public LogRepository(WebApi.DataAccess.LogContext context)
		{
			_context = context;
		}

        public LogRepository()
        {
        }

        public void GetAll(T entity)
		{
			_dbSet.ToList();
		}
		public void Add(T entity)
		{
			_dbSet.Add(entity);
		}
		public void Delete(T entity)
		{
			_dbSet.Remove(entity);
		}
		public void Save(T entity)
		{
			_context.SaveChanges();
		}
	}
}