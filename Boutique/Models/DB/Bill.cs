using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutique.Models.DB
{
    public class Bill
    {
        [Key]
        public int billId { get; set; }
        [Required]
        public DateTime billDate { get; set; }
        [Required]
        public double totalPrice { get; set; }
        [ForeignKey("user")]
        public string userId { get; set; }
        public ApplicationUser user { get; set; }
        public virtual ICollection<billDetails> billDetails { get; set; }
    }
}