using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Admin
    {
        public int UserRoleID { get; set; }
        public int AdminID { get; set; }
        public DateTime HireDate { get; set; }
        public int OfficePhone { get; set; }
    }
}