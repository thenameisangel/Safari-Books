using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SafariBooks24.Models;

namespace SafariBooks.Models
{
    public class Employee : ApplicationUser
    {
        [Required]
        public int EmployeeID { get; set; }

        [Required]
        public Boolean Manager { get; set; }

    }
}