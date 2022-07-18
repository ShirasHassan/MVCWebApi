using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test_Neudesic.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "id")]
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}