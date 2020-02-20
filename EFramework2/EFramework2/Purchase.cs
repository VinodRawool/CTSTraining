using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFramework2
{
     class Purchase
    {   [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int CId { get; set; }
        public int PId { get; set; }
        public virtual  Customer Customer1 { get; set; }
        public virtual Product Product1 { get; set; }
            
    }
}