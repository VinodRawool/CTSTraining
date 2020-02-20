using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext cs = new OrderContext();
            cs.Customers.Add( new Customer {CName="Vinod" });
            cs.Customers.Add(new Customer { CName = "Momo" });
            cs.Customers.Add(new Customer { CName = "Rohit" });
            cs.Customers.Add(new Customer { CName = "Sarva" });

            cs.Products.Add(new Product { PNameP = "Bottle" });
            cs.Products.Add(new Product { PNameP = "Pen" });
            cs.Products.Add(new Product { PNameP = "NoteBook" });
            cs.Products.Add(new Product { PNameP = "Diary" });

            cs.Orders.Add(new Order { });
        }
    }
}
