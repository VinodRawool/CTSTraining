using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityExample2
{
    class Customer
    {   [Key]
        public int CID { set; get; }
        public string CName { set; get; }
       
    }
}
