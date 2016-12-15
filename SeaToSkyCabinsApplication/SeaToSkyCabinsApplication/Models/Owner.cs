using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Owner
    {
        public User User { get; set; }
        public int RoleID { get; set; }
        public string OwnerID { get; set; }
        public int SIN { get; set; }
        public int DirectDepositRouting { get; set; }
        public int DirectDepositAccount { get; set; }
    }
}