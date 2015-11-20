using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SafariBooks.Models
{
    public class CreditCard
    {
        [Required]
        public int CreditCardID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Display(Name = "Card Number")]
        [Required]
        public int CardNumber { get; set; }

        public enum CreditCardType
        {
            Visa,
            MasterCard,
            [Display(Name = "American Express")]
            AMEX,
            Discover
        };

        public CreditCardType CardType { get; set; }


    }

}