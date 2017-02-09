using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Admin
    {
        [Display(Name = "Admin ID")]
        public string AdminID { get; set; }
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Office Phone")]
        public int OfficePhone { get; set; }

        public virtual User User { get; set; }
    }
}
}