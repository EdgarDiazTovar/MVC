using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class ProductCE
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; }

    }
    
}