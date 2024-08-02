using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Details:")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Prix HT:")]
        public decimal Prix { get; set; }
    }
}