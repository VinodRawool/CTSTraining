using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityExample2
{
    class Order
    {   
        [Key]
        public int Id { set; get; }
       
        public int CId { set; get; }
        
        public int PId { get; set; }
        public int Quantity { get; set; }
    }
}
