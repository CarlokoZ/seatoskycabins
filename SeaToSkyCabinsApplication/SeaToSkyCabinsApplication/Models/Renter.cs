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
        [Display(Name ="RENTER ID")]
        public int RenterID { get; set; }
        [Display(Name = "SECONDARY PHONE")]
        public int SecondaryPhone { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "PROFILE PICTURE")]
        public string ProfilePicture { get; set; }
        [Display(Name = "RATING")]
        public decimal RenterRating { get; set; }
        [Required]
        [Display(Name = "PHOTO ID NUMBER")]
        public string PhotoIDNumber { get; set; }
        [Required]
        [Display(Name = "CARD NUMBER")]
        public int ChargeCardNumber { get; set; }
        [Required]
        [Display(Name = "CARD EXPIRATION")]
        public int ChargeCardExpiration { get;set; }
        [Required]
        [Display(Name = "CARD CODE")]
        public int ChargeCardCode { get; set; }

    }
}