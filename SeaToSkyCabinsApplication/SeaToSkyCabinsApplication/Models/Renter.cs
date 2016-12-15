using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Renter
    {
        public int RoleID { get; set; }
        public int RenterID { get; set; }
        public int SecondaryPhone { get; set; }
        public string ProfilePicture { get; set; }
        public decimal RenterRating { get; set; }
        public string PhotoIDNumber { get; set; }
        public int ChargeCardNumber { get; set; }
        public int ChargeCardExpiration { get;set; }
        public int ChargeCardCode { get; set; }

    }
}