using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class productSize
    {
        [Key]
        public int productSizeId { get; set; }
        [Required]
        public string size { get; set; }
        [Required]
        public int availableSizeCount { get; set; }
        [ForeignKey("product")]
        public int productId { get; set; }
        public Product product { get; set; }
    }
}