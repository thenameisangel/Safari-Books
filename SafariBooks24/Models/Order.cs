using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class Order
    {
        [Required]
        public int OrderID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        List<OrderDetail> Products { get; set; }

        [Required]
        public string CouponID { get; set; }

        [Required]
        public int Subtotal { get; set; }

        [Required]
        public int Shipping { get; set; }

        [Required]
        public int Total { get; set; }

        [Required]
        public string CreditCard { get; set; }

        [Required]
        public Boolean Status { get; set; }


    }
}