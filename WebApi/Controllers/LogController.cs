using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using WebApi.DataAccess;
using Business.Abstract;
using Business.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private ILogService _logService;
        public Log log;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }
        [HttpGet(template: "getAll")]
        public IQueryable<Log> GetAll()
        {
            return _logService.GetAll();
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logService.Add(log);
            _logService.Save();
        }

    }
}
