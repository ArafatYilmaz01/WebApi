using Business.Abstract;
using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.DataAccess;

namespace Business.Concrete
{
    public class LogManager : ILogService

    {
        private BaseRepository<Log> _logRepository;
        
        public LogManager(BaseRepository<Log> logRepository)
        {
            _logRepository = logRepository;
        }

        public void Add(Log log)
        {
            _logRepository.Add(log);
        }

        public void Delete(int logId)
        {
           if(logId > 0)
            {
                _logRepository.Delete(logId);
            }

            throw new Exception("Id cannot be less than 1 ");
        }

        public IQueryable<Log> GetAll()
        {
            return _logRepository.GetAll();
        }

        public void Save()
        {
            _logRepository.Save();
        }
    }
}
