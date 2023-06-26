using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double? Discount { get; set; }
        public double? Total { get; set; }
    }
}
