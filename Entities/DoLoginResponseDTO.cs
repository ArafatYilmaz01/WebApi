using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class DoLoginResponseDTO
    {
        public bool Result { get; set; }
        public string Message { get; set; } = null!;
        public string ErrorMessage { get; set; } = null!;
        public string ErrorCode { get; set; } = null!;
        
    }
    public class ResponseSuccessDTO:DoLoginResponseDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public DateTime PackageEndDate { get; set; }
        public string ApiCode { get; set; }


    }
    public class ResponseErrorDTO: DoLoginResponseDTO
    {
        public object Response { get; set; } = null!;
    }
}
