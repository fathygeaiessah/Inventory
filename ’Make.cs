using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppInventory.Models
{
    public class Make
    {
        [Required]
        [Display(Name = "م")]
        public int ID { get; set; }
        [Display(Name = "الماركة")]
        public string MakeName { get; set; }
        [Display(Name = "المنشأ")]
        public string Origin { get; set; }
    }
}
