using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public string? Avatar { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
