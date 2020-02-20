using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityExample2
{
    class Product
    {
        [Key]
        public int PId { get; set; }
        public string PNameP { get; set; }
    }
}
