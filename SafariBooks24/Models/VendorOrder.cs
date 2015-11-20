using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class VendorOrder
    {
        [Required]
        public int VendorOrderID { get; set; }

        [Required]
        public List<VendorOrderDetail> BookstoOrder { get; set; }

        [Required]
        public Boolean Automatic { get; set; }

        [Required]
        public DateTime TimeofOrder { get; set; }
    }
}