using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTOs
{
    public class ResponseErrorDTO : DoLoginResponseDTO
    {
        public object Response { get; set; }
    }
}
