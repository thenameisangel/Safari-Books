using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class Recommendation
    {
        [Required]
        public int RecommendationID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        public List<Book> RecBooks { get; set; }
    }
}