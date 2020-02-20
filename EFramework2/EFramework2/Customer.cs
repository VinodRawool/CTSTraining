using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFramework2
{
    class Customer
    {   [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public string CAdd { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
