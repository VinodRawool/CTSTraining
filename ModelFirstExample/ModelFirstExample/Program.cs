using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstExample
{
    class Program
    {
        static ModelFirstEntityContainer mfc = new ModelFirstEntityContainer();
        static void Main(string[] args)
        {
            //Insert();

            ShowData();

            Console.ReadKey();
        }

        private static void ShowData()
        {
            Console.WriteLine("Category.......");

            foreach (var x in mfc.Categories)
            {
                Console.WriteLine("{0}\t{1}", x.CId, x.CTitle);
            }


            Console.WriteLine("Products.....");
            foreach (var x in mfc.Products)
            {
                Console.WriteLine("{0}\t{1}\t{2,-10}\t{3}", x.PId, x.PTitle, x.CId, x.Category.CTitle);
            }
        }

        private static void Insert()
        {
            var a = new List<Category>
           {
               new Category{CId=1,CTitle="Dairy" },
               new Category{CId=2,CTitle="Beverages" },
               new Category{CId=3,CTitle="Personnal Care" }
           };

            a.ForEach(x => mfc.Categories.Add(x));
            mfc.SaveChanges();

            var b = new List<Product>
           {
               new Product{PId=1,PTitle="Cheese",CId=1 },
               new Product{PId=2,PTitle="Soap" ,CId=3},
               new Product{PId=3,PTitle="SoftDrink",CId=3 },
               new Product{PId=4,PTitle="Tea",CId=2},
               new Product{PId=5,PTitle="Milk",CId=2 }
           };

            b.ForEach(x => mfc.Products.Add(x));
            mfc.SaveChanges();
        }
    }
}
