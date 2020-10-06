using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class billDetails
    {
        [Key]
        public int billDetailsId { get; set; }
        [ForeignKey("bill")]
        public int billId { get; set; }
        [ForeignKey("product")]
        public int productId { get; set; }
        [Required]
        public int count { get; set; }
        [Required]
        public double price { get; set; }
        public string size { get; set; }
        public Bill bill { get; set; }
        public Product product { get; set; }
    }
}