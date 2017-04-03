using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppInventory.Models
{
    public class Store
    {
        [Required]
        [Display(Name = "م")]
        public int ID { get; set; }
        [Display(Name = "المخزن")]
        public string StoreName { get; set; }
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Display(Name = "التليفون")]
        public string Phone { get; set; }
        [Display(Name = "المسؤول")]
        public string Responsible { get; set; }
    }
}
