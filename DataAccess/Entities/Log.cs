using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Log
    {
     
        [Key]
        public int LogId { get; set; }
        public string LogTypeOfResponse { get; set; }
        public string MessageOfResponse { get; set; }
    }
}
