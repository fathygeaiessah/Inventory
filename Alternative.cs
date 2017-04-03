using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppInventory.Models
{
    public class Alternative
    {
        [Display(Name = "م")]
        public int ID { get; set; }
        [Display(Name = "الصنف")]
        public int PartID { get; set; }
        [Display(Name = "البديل")]
        public int PartAlternativeID { get; set; }
        public ICollection<Part> PartAlternatives { get; set; }
        public Part Part { get; set; }
    }
}
