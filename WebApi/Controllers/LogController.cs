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

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private ILogService _logService;
        public LogContext log;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }
        [HttpGet(template: "getAll")]
        public IActionResult GetList()
        {
            return Ok(_logService.GetAll());
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logService.Add(log);
            _logService.Save(log);
        }

    }
}
