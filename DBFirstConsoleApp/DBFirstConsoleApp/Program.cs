using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstConsoleApp
{
    class Program
    {
        static EFWork2Entities efw = new EFWork2Entities();
        static void Main(string[] args)
        {

            var cc = new Customer { CName = "Sara", CAdd = "Pune" };
            efw.Customers.Add(cc);
            efw.SaveChanges();

            Console.WriteLine("\n        Customer Details..\n");
            foreach(var c in efw.Customers)
           {
               Console.WriteLine("{0}\t{1}\t{2}",c.CId,c.CName,c.CAdd);
           }

            //Console.WriteLine("\n        Products Details..\n");
            //foreach (var c in efw.Products)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}", c.PId, c.PName, c.Price);
            //}

            Console.WriteLine("\n        Purchase Details..\n");
            foreach (var v in efw.Purchases)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", v.Id, v.OrderDate, v.PId, v.Product.PName, v.Product.Price);
            }

            Console.ReadKey();
        }
    }
}
