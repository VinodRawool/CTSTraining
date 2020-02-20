using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            File fs = new File.Append("C:/Users/Admin/Documents/test.txt");
            StreamWriter sw = new StreamWriter();


            //StreamWriter sw = File.AppendText("C:/Users/Admin/Documents/test.txt");
            Console.WriteLine("Writing into File\n");
            Console.WriteLine("Enter Your name :");
            String name=Console.ReadLine();
            sw.WriteLine("Name : {0}",name);
            Console.WriteLine("Enter Your Age :");
            String age = Console.ReadLine();
            sw.WriteLine("Age : {0}", age);
            sw.Close();

            Console.WriteLine("\nReading From the File\n");
            StreamReader rw = File.OpenText("C:/Users/Admin/Documents/test.txt");
            string s;
            while ((s = rw.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            rw.Close();
            Console.ReadKey();

        }
    }
}
