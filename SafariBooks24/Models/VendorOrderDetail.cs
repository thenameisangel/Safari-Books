using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class VendorOrderDetail
    {
        [Required]
        public int VendorOrderDetailID { get; set; }

        [Required]
        public string BookID { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}