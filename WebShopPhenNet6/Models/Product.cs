using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public double? ProductPrice { get; set; }
        public double? Discount { get; set; }
        public string? Thumb { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool HomeFlag { get; set; }
        public bool Active { get; set; }
        public string? ProductTitle { get; set; }
        public int? UnitsInStock { get; set; }
    }
}
