using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EFExample.cs
{
    class Product
    {   
        [Key]
        public int PId { set; get; }
        public string PName { set; get; }
        public int Price { get; set; }

    }
}
