using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? CategoryDescription { get; set; }
        public string? CategoryThumb { get; set; }
        public int? BaseCategoryId { get; set; }
    }
}
