using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class GetSalesResponseDTO
    {
        public bool Result { get; set; }
        public string Message { get; set; } = null!;
        public string ErrorMessage { get; set; } = null!;
        public string ErrorCode { get; set; } = null!;
        public object Response { get; set; } = null!;//Birinde nullable olmaması durumuna bak bir yine
    }
}
