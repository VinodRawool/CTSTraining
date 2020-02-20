using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstHandsOn
{
    class Program
    {
        static DBFirstEntities dbt = new DBFirstEntities();
        static void Main(string[] args)
        {
            //AddData();

            ShowData();

            Console.ReadKey();

        }

        private static void ShowData()
        {
            Console.WriteLine("\n..........Category.......\n");
            foreach (var x in dbt.Categories)
            {
                Console.WriteLine("{0}\t{1}", x.CId, x.CName);
            }

            Console.WriteLine("\n\n..........Products.......\n");
            foreach (var x in dbt.Products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", x.PId, x.Title, x.Price, x.CId, x.Category.CName);
            }
        }

        private static void AddData()
        {
            var a = new List<Category>
            {
                new Category{CId=1,CName="Dairy" },
                new Category{CId=2,CName="Beverages" },
                new Category{CId=3,CName="PersonalCare" },
                new Category{CId=4,CName="Others" }
            };

            a.ForEach(x => dbt.Categories.Add(x));
            dbt.SaveChanges();


            var b = new List<Product>
            {
                new Product{PId=1,Title="Cheeses",Price=99,CId=1 },
                new Product{PId=2,Title="Coffe",Price=219,CId=2 },
                new Product{PId=3,Title="Soda",Price=50,CId=2 },
                new Product{PId=4,Title="Shampoo",Price=199,CId=3 },
                new Product{PId=5,Title="Greetings Card",Price=79,CId=4 },
                new Product{PId=6,Title="Milk",Price=59,CId=1 },
            };

            b.ForEach(x => dbt.Products.Add(x));
            dbt.SaveChanges();
        }
    }
}
