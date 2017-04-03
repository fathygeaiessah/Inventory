using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppInventory.Models
{
    public class PartsInStore
    {
        [Display(Name = "م")]
        public int ID { get; set; }
        [Display(Name = "الصنف")]
        public int PartID { get; set; }
        [Display(Name = "المخزن")]
        public int StoreID { get; set; }
        [Display(Name = "الكمية")]
        public int QtyInStore { get; set; }
        [Display(Name = "حد الطلب")]
        public int QtyInStoreMin { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime Date { get; set; }
        public ICollection<Part> Parts { get; set; }
        public ICollection<Store> Stores { get; set; }

    }
}
