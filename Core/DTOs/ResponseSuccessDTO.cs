using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTOs
{
    public class ResponseSuccessDTO : DoLoginResponseDTO
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
}
