using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExample.cs
{
    class Customer
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }

        // Foreign key   
        [Display(Name = "Product")]
        public virtual int PId { get; set; }

        [ForeignKey("PId")]
        public virtual Product Products { get; set; }

     
        public string PName { set; get; }
        public int Price { get; set; }
        public int Quantity { get; set; }



    }
}
