using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // EmployeeContext ect = NewMethod();


            // Search();
            ShowData();

            UpdateDesgnation();
            ShowData();


            Console.ReadKey();

         

        }

        private static void UpdateDesgnation()
        {
            Console.WriteLine("Enter EId to be modify :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter new Designation \n :");
            string d = (Console.ReadLine());

            EmployeeContext ec = new EmployeeContext();
            var result = ec.Emp;
            var res = from a in result where a.EId == id select a;

            foreach (Employee e in res)
            {
                e.EDesignation = d;
            }
            ec.SaveChanges();
        }

        private static void Search()
        {
            Console.WriteLine("Enter EId to search for:");
            int i = int.Parse(Console.ReadLine());
            EmployeeContext ec = new EmployeeContext();
            var result = ec.Emp;
            var res = from a in result where a.EId == i select a;

            foreach (Employee e in res)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.EId, e.EName, e.EDesignation, e.ESalary);
            }
        }



        private static void ShowData()
        {
            EmployeeContext ect = new EmployeeContext();
             
            Console.WriteLine();
            Console.WriteLine();
            var Empl = ect.Emp;
            foreach (var e in Empl)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.EId, e.EName, e.EDesignation, e.ESalary);
            }

          
        }

        private static EmployeeContext NewMethod()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            int sal = int.Parse(Console.ReadLine());


            EmployeeContext ect = new EmployeeContext();
            ect.Emp.Add(new Employee { EName = name, EDesignation = desg, ESalary = sal });
            ect.SaveChanges();
            return ect;
        }
    }
}
