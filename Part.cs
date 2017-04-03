using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppInventory.Models;

namespace WebAppInventory.Models
{
    public class Part
    {
        [Required]
        [Display(Name = "م")]
        public int ID { get; set; }
        public int MakeID { get; set; }
        public int CategoryID { get; set; }
        [Display(Name = "رقم الصنف")]
        public string PartNo { get; set; }
        [Display(Name = "رقم سابق")]
        public string PrevPartNo { get; set; }
        [Display(Name = "الصنف")]
        public string PartDescription { get; set; }
        [Display(Name = "الكمية المتاحة")]
        public int QtyAll { get; set; }
        [Display(Name = "حد الطلب")]
        public int QtyMin { get; set; }
        [Display(Name = "آخر سعر شراء")]
        public decimal UPricePu { get; set; }
        [Display(Name = "سعر 1")]
        public decimal UPrice1 { get; set; }
        [Display(Name = "سعر 2")]
        public decimal UPrice2 { get; set; }
        [Display(Name = "سعر3")]
        public decimal UPrice3 { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime Date { get; set; }

        public ICollection<Make> Makes { get; set; }
        public Category Category
        {
            get; set;
        }
        }
}
