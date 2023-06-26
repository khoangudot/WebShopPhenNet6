using System;
using System.Collections.Generic;

namespace WebShopPhenNet6.Models
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? RoleDescription { get; set; }
    }
}
