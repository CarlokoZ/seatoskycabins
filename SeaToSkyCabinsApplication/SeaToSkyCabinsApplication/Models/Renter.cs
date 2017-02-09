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
        [Display(Name = "Renter ID")]
        public string RenterID { get; set; }

        public int UserID { get; set; }

        [Display(Name = "SECONDARY PHONE")]
        public int SecondaryPhone { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "PROFILE PICTURE")]
        public string ProfilePicture { get; set; }
        
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

        public virtual User User { get; set; }
    }
}