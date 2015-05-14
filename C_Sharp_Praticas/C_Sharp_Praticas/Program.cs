using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Praticas
{
    class Program
    {
        static void Main(string[] args)
        {
            // STUDENT 1
            Student student = new Student("John", 5.2, 4.1);

            // STUDENT 2
            Student student2 = new Student();
            student2.name = "Nicky";
            student2.test1 = 6;
            student2.test2 = 5;        

            // DISPLAY CONSOLE
            Console.WriteLine("{0,-20} {1,-10}", "Student", "Final Note");
            Console.WriteLine("{0,-20} {1,7}", student.name, student.ClassFinal());
            Console.WriteLine("{0,-20} {1,7}", student2.name, student2.ClassFinal());
            Console.WriteLine("------------------------------------------------------");
            student.CompleteClassFinal();
            student2.CompleteClassFinal();
            Console.ReadLine();
        }
    }
}
