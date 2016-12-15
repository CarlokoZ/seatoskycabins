using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace SeaToSkyCabinsApplication.Models
{
    public class Renter
    {
        [Required]
        public User User { get; set; }
        public int RoleID { get; set; }
        [Key]
        public int RenterID { get; set; }
        public int SecondaryPhone { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ProfilePicture { get; set; }
        public decimal RenterRating { get; set; }
        [Required]
        public string PhotoIDNumber { get; set; }
        [Required]
        public int ChargeCardNumber { get; set; }
        [Required]
        public int ChargeCardExpiration { get;set; }
        [Required]
        public int ChargeCardCode { get; set; }

    }
}