using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class DoLoginResponseDTO
    {
        public bool Result { get; set; }
        public string Message { get; set; } 
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; } 
        
    }
   
}
