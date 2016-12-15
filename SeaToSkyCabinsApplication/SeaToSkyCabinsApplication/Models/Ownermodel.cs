using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Ownermodel
    {
        public int UserRoleID { get; set; }
        public int OwnerID { get; set; }
        public int SIN { get; set; }
        public int DirectDepositRouting { get; set; }
        public int DirectDepositAccount { get; set; }
    }
}