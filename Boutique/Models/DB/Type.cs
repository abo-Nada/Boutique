using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class Type
    {
        [Key]
        public int typeId { get; set; }
        [Required]
        public string typeName { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}