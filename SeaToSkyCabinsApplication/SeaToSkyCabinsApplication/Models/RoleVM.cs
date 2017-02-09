using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class RoleVM
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}