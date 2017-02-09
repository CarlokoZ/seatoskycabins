using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class User
    {
        [Display(Name ="USER ID")]
        public int UserID { get; set; }
        [Display(Name = "ROLE ID")]
        public int RoleID { get; set; }
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }
        [Display(Name = "FIRST NAME")]
        public string FirstName { get; set; }
        [Display(Name = "LAST NAME")]
        public string LastName { get; set; }
        [Display(Name = "BIRTH DATE")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "ADDRESS")]
        public string Address { get; set; }
        [Display(Name = "CITY")]
        public string City { get; set; }
        [Display(Name = "PROVINCE")]
        public string Province { get; set; }
        [Display(Name = "POSTAL CODE")]
        public string PostalCode { get; set; }
        [Display(Name = "EMAIL")]
        public string Email { get; set; }
        [Display(Name = "PHONE NUMBER")]
        public int PhoneNumber { get; set; }

        public virtual ICollection<Owner> Owners { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual ICollection<Renter> Renters { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}