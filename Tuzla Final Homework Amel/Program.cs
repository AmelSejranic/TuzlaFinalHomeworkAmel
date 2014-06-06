using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuzla_Final_Homework_Amel
{
    class Program
    {

        public static List<Student> students = new List<Student>(); //lista objekata tipa Student

        static void Main(string[] args)
        {

            students.Add(new Student("YYY", "mail", 22));
            students.Add(new Student("AAA", "mail", 25));
            students.Add(new Student("XXX", "mail", 27));


            students.Sort();
            foreach (Student n in students)
            {
                Console.WriteLine(n.name);
            }
            Console.ReadLine();

        }
    }
}
