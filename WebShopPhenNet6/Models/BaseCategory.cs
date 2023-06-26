using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class BaseCategory
    {
        public int BaseCategoryId { get; set; }
        public string BaseCategoryName { get; set; } = null!;
        public string? BaseCategoryDescription { get; set; }
    }
}
