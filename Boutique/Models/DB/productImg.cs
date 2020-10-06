using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class productImg
    {
        [Key]
        public int productImgId { get; set; }
        [Required]
        public string imgName { get; set; }
        [ForeignKey("product")]
        public int productId { get; set; }
        public Product product { get; set; }
    }
}