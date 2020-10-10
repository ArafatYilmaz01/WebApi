using Business.Abstract;
using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using WebApi.DataAccess;

namespace Business.Concrete
{
    public class LogManager : ILogService

    {
        private LogRepository<LogContext> _logRepository= new LogRepository<LogContext>();
        
        

        public void Add(LogContext log)
        {
            _logRepository.Add(log);
        }

        public void Delete(int log)
        {
           
            _logRepository.Delete(log);
        }

        public List<LogContext> GetAll()
        {
            return (List<LogContext>)_logRepository.GetAll();
        }

        public void Save(LogContext log)
        {
            _logRepository.Save();
        }
    }
}
