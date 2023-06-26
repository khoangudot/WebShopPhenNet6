using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }
    }
}
