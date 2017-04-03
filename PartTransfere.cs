using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppInventory.Models
{
    public class PartTransfere
    {
        [Display(Name = "م")]
        public int ID { get; set; }
        [Display(Name = "الصنف")]
        public int PartID { get; set; }
        [Display(Name = "الكمية")]
        public int QtyTrans { get; set; }
        [Display(Name = "من مخزن")]
        public int FromStoreID { get; set; }
        [Display(Name = "الى مخزن")]
        public int ToStoreID { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime Date { get; set; }
        public ICollection<Part> Parts { get; set; }
        public ICollection<Store> FromStores { get; set; }
        public ICollection<Store> ToStores { get; set; }
    }
}
