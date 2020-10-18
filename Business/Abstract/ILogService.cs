using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.DataAccess;

namespace Business.Abstract
{
    public interface ILogService
    {
        IQueryable<Log> GetAll();
        void Add(Log log);
        void Delete(int logID);
        void Save();
        

    }
}
