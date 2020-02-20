using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityExample
{
    class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesignation { get; set; }
        public int ESalary { get; set; }
    }
}
