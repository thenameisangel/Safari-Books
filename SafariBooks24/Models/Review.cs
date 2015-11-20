using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class Review
    {
        [Required]
        public int ReviewID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        public int BookID { get; set; }

        [Required]
        public int RatingID { get; set; }

        [Display(Name = "Review")]
        [Required]
        public string ReviewText { get; set; }

        [Required]
        public Boolean Approved { get; set; }

        [Required]
        public DateTime TimeOfReview { get; set; }
    }
}