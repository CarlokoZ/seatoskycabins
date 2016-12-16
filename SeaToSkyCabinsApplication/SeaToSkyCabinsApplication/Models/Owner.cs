using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Owner
    {
        public User User { get; set; }
        [Display(Name = "ROLE ID")]
        public int RoleID { get; set; }
        [Display(Name = "OWNER ID")]
        public string OwnerID { get; set; }
        [Display(Name = "SIN")]
        public int SIN { get; set; }
        [Display(Name = "DIRECT DEPOSIT ROUTING")]
        public int DirectDepositRouting { get; set; }
        [Display(Name = "DIRECT DEPOSIT ACCOUNT")]
        public int DirectDepositAccount { get; set; }
    }
}