using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Owner
    {
        [Display(Name = "OWNER ID")]
        public string OwnerID { get; set; }

        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "SIN")]
        public int SIN { get; set; }

        [Display(Name = "DIRECT DEPOSIT ROUTING")]
        public int DirectDepositRouting { get; set; }

        [Display(Name = "DIRECT DEPOSIT ACCOUNT")]
        public int DirectDepositAccount { get; set; }

        public virtual User User { get; set; }
    }
}