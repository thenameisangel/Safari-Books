using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class Coupon
    {
        [Required]
        public int CouponID { get; set; }

        [Display(Name = "Coupon Code")]
        [Required]
        public string CouponCode { get; set; }

        [Display(Name = "Coupon Type")]
        [Required]
        public string CouponType { get; set; }

        [Display(Name = "Active?")]
        [Required]
        public Boolean Active { get; set; }
    }
}