using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class Book
    {
        [Display(Name = "Unique Number")]
        [Required]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Author's First Name")]
        [Required]
        public string AuthorFName { get; set; }

        [Display(Name = "Author's Last Name")]
        [Required]
        public string AuthorLName { get; set; }

        [Display(Name = "Average Rating")]
        public decimal AvgRating { get; set; }

        [Display(Name = "In Stock")]
        [Required]
        public Boolean InStock { get; set; }

        [Display(Name = "Number of Copies Sold")]
        public int NumSold { get; set; }

        [Display(Name = "Publication Date")]
        [Required]
        public DateTime PublicationDate { get; set; }

        [Display(Name = "Price")]
        [Required]
        public decimal SellingPrice { get; set; }

        [Display(Name = "Discounted Price")]
        public decimal DiscountPrice { get; set; }

        [Required]
        public string Genre { get; set; }

        public string Supplier { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [Display(Name = "On-Hand Inventory")]
        [Required]
        public int InventoryOnHand { get; set; }

        [Display(Name = "Reorder Point")]
        [Required]
        public int ReorderPoint { get; set; }

        [Display(Name = "Quantity Needed?")]
        //quantity we need to order?
        [Required]
        public int NeedToOrder { get; set; }
    }
}