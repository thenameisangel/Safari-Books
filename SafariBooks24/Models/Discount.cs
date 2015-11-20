using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class Discount
    {
        [Required]
        public int DiscountID { get; set; }

        [Display(Name = "Discount Type")]
        [Required]
        public string DiscountType { get; set; }

        [Display(Name = "Discount Amount")]
        [Required]
        public int DiscountAmount { get; set; }

        [Display(Name = "Active?")]
        [Required]
        public Boolean Active { get; set; }

        [Required]
        public int BookID { get; set; }
    }
}