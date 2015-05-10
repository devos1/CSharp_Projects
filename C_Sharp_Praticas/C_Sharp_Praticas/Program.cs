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
            Student student = new Student("John", 5.2, 4.1);
            Console.WriteLine("{0,-20} {1,-10}", "Student", "Final Note");
            Console.WriteLine("{0,-20} {1,7}", student.name, student.ClassFinal());
            Console.WriteLine("------------------------------------------------------");
            student.CompleteClassFinal();
            Console.ReadLine();
        }
    }
}
