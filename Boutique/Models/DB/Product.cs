using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string code { get; set; }
        [Required]
        public string productName { get; set; }
        public string description { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public int availableCount { get; set; }
        public string color { get; set; }
        [ForeignKey("category")]
        public int categoryId { get; set; }
        [ForeignKey("type")]
        public int typeId { get; set; }
        public Category category { get; set; }
        public Type type { get; set; }
        public virtual ICollection<productImg> productImgs { get; set; }
        public virtual ICollection<productSize> productSizes { get; set; }
        public virtual ICollection<billDetails> billDetails { get; set; }
    }
}