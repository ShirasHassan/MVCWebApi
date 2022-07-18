using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test_Neudesic.Models
{
    public class Item
    {
        [Column("id")]
        [Key]
        public int ItemId { get; set; }

        [Required]
        [Display(Name = "desc")]
        [StringLength(50)]
        [Column("description")]
        public string Description { get; set; }

        [ForeignKey("Category")]
        [Column("category_id")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}