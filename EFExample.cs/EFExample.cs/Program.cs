using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerContext cc = new CustomerContext();
            //   cc.Products.Add(new Product { PId=1001,PName="Bottle",Price=199});
            //  cc.Products.Add(new Product { PId = 1002, PName = "Pen", Price = 60 });
            //   cc.Products.Add(new Product { PId = 1003, PName = "NoteBook", Price = 159 });
            //   cc.SaveChanges();

            Console.WriteLine("      Store List \n\n");
            var res1=cc.Products;
            foreach (var x in res1)
            {
                Console.WriteLine("{0}\t{1}\t{2}",x.PId,x.PName,x.Price);
            }
            Console.WriteLine("----------------------");



            Console.WriteLine("\n\nEnter Customer Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Id:");
            int pid = int.Parse(Console.ReadLine());
            var pc=cc.Products;
            var res = from a in pc where a.PId == pid select a;

            string pname = "";
            int pprice = 0;

            Console.WriteLine("Enter Quantity:");
            int qty = int.Parse(Console.ReadLine());


            foreach (var s in res)
            {
                pname = s.PName;
                pprice = s.Price;
            }

            cc.Customers.Add(new Customer { CName = name, PId = pid, PName = pname,Price=pprice,Quantity=qty });
            cc.SaveChanges();

        }
    }
}
