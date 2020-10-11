using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.DataAccess;

namespace Business.Abstract
{
    public interface ILogService
    { 
        List<LogContext> GetAll();
        void Add(LogContext log);
        void Delete(int logID);
        void Save(LogContext log);
        

    }
}
