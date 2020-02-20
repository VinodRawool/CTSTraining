using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // AddData();

            ShowData();

            Console.ReadKey();


        }

        private static void ShowData()
        {
            CustomerContext cc1 = new CustomerContext();


            var cust = cc1.Customer;
            Console.WriteLine("\n   customers details ....\n");
            foreach (var v in cust)
            {
                Console.WriteLine("{0}\t{1}\t{2}", v.CId, v.CName, v.CAdd);
            }

            Console.WriteLine("\n   products details ....\n");
            var pro = cc1.Products;
            foreach (var v in pro)
            {
                Console.WriteLine("{0}\t{1}\t{2}", v.PId, v.PName, v.Price);
            }

            Console.WriteLine("\n   Purchases Details ....\n");
            var purch = cc1.Purchases;

         

            
            



         foreach (var v in purch)
            {

                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}",
                    v.Id, v.OrderDate.ToShortDateString(), v.PId, v.Product1.PName, v.Product1.Price, v.CId, v.Customer1.CName);
            }
        }

        private static void AddData()
        {
            CustomerContext cc = new CustomerContext();

            var cust = new List<Customer>
            {
                new Customer { CName = "Vinod", CAdd = "Pune" },
                new Customer{ CName="Momo",CAdd="Pune"},
                new Customer{ CName="Rohit",CAdd="Vijaywada"},
                new Customer{ CName="Sarva",CAdd="Chennai"}

            };

            foreach (var v in cust)
            {
                cc.Customer.Add(v);
            }
            cc.SaveChanges();

            var product = new List<Product>
            {
                new Product{ PName="Rice",Price=76},
                new Product{ PName="Dal",Price=176},
                new Product{ PName="Sweets",Price=300},
                new Product{ PName="Snacks",Price=265}
            };

            product.ForEach(pr => cc.Products.Add(pr));
            cc.SaveChanges();


            var purch = new List<Purchase>
            {
                new Purchase{ OrderDate=DateTime.Now,PId=1,CId=2},
                new Purchase{ OrderDate=DateTime.Now,PId=1,CId=3},
                new Purchase{ OrderDate=DateTime.Now,PId=4,CId=1},
                new Purchase{ OrderDate=DateTime.Now,PId=2,CId=1}
            };

            purch.ForEach(pur => cc.Purchases.Add(pur));
            cc.SaveChanges();
        }
    }
}
