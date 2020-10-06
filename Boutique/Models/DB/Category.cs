using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        [Required]
        public string categoryName { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}