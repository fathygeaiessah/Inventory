using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppInventory.Models
{
    public class Category
    {
        [Required]
        [Display(Name = "م")]
        public int ID { get; set; }
        [Display(Name = "المجموعة")]
        public string CategoryName { get; set; }
        [Display(Name = "المجموعة الرئيسية")]
        public string ParentCategory { get; set; }
    }
}
