using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFramework2
{
    class Product
    {   [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
