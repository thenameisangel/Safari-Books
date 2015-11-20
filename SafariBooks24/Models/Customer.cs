using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SafariBooks24.Models;

namespace SafariBooks.Models
{
    public class Customer : ApplicationUser
    {
        [Required]
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "State can only be 2 letters. Be sure to use the abbreviation.")]
        [Required]
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        [Required]
        public string ZipCode { get; set; }

        [Required]
        public Boolean Active { get; set; }
    }
}