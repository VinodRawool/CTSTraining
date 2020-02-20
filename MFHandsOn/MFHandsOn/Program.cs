using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MFHandsOn
{
    class Program
    {
        static Model1Container mc = new Model1Container();
        static void Main(string[] args)
        {
            //  InsertData();
            //ShowData();
           // showResult();

            try {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("vinodrawool00@gmail.com");
                mail.To.Add("@gmail.com");
                mail.Subject = "";
                mail.Body = " ?";


                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("vinodrawool00@gmail.com", "");
                smtp.EnableSsl = true;

                Console.WriteLine("Mail Sent");

                smtp.Send(mail);
            }
            catch (Exception x) { Console.WriteLine(x.ToString()); }



            Console.ReadKey();

        }

        private static void showResult()
        {
            Console.WriteLine("\n\n        Results:\n");
            Console.WriteLine("Enter Student Id:\n");
            int s = int.Parse(Console.ReadLine());
            var xx = mc.Results;
            int x = (from a in xx where a.SId == s select a.Marks).Sum();
            var y = from a in xx where a.SId == s select a;

            foreach (var res in y)

            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3,12}\t{4}", res.SId, res.Student.SName, res.EId, res.Exam.EName, res.Marks);
            }

            if (x > 175)
            {
                Console.WriteLine("\n\n Total: {0} ",x);
                Console.WriteLine(" Result: Pass "); }
            else { Console.WriteLine("\n\n Result: Fail "); }
        }

        private static void ShowData()
        {
            var xx = mc.Results;
           // var x = (from a in xx where a.SId == 1 select a.Marks).Sum();

            foreach (var res in xx)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3,12}\t{4}", res.SId, res.Student.SName, res.EId, res.Exam.EName, res.Marks);
            }
            Console.ReadKey();
        }

        private static void InsertData()
        {
            var a = new List<Student>
            {
                new Student{SName="Vinod",SSchool="KVBEG" },
                new Student{SName="Momo",SSchool="KVBEG" },
                new Student{SName="Rohit",SSchool="APS" },
                new Student{SName="Vinod",SSchool="SRMCollege" },
            };

            a.ForEach(x => mc.Students.Add(x));
            mc.SaveChanges();


            var b = new List<Exam>
            {
                new Exam{EName="Maths",EDate=Convert.ToDateTime("2020-5-6"),MaxMarks=100 },
                new Exam{EName="Science",EDate=Convert.ToDateTime("2020-5-8"),MaxMarks=100 },
                new Exam{EName="Computer",EDate=Convert.ToDateTime("2020-5-10"),MaxMarks=100 },
                new Exam{EName="English",EDate=Convert.ToDateTime("2020-5-11"),MaxMarks=100},
            };

            b.ForEach(x => mc.Exams.Add(x));
            mc.SaveChanges();


            var c = new List<Result>
            {
                new Result{ SId=1,EId=1,Marks=96},
                new Result{ SId=1,EId=2,Marks=86},
                new Result{ SId=1,EId=3,Marks=85},
                new Result{ SId=1,EId=4,Marks=89},
                new Result{ SId=2,EId=1,Marks=78},
                new Result{ SId=2,EId=2,Marks=86},
                new Result{ SId=2,EId=3,Marks=85},
                new Result{ SId=2,EId=4,Marks=91},
                new Result{ SId=3,EId=1,Marks=86},
                new Result{ SId=3,EId=2,Marks=75},
                new Result{ SId=3,EId=3,Marks=75},
                new Result{ SId=3,EId=4,Marks=96},
                new Result{ SId=4,EId=1,Marks=83},
                new Result{ SId=4,EId=2,Marks=73},
                new Result{ SId=4,EId=3,Marks=81},
                new Result{ SId=4,EId=4,Marks=88},
            };

            c.ForEach(x => mc.Results.Add(x));
            mc.SaveChanges();
        }
    }
}
