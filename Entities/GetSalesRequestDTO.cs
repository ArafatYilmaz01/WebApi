using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class GetSalesRequestDTO
    {
        public string ApiCode { get; set; }
        public int StoreId { get; set; }
        public string OrderStatus { get; set; }
        public int InvoiceStatus { get; set; }
    }
}
