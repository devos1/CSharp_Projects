using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Praticas;

namespace Exercice_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Var
            int nbStudents;
            bool parseIntOK;
            Student[] students;

            // Ask to user student's number
            Console.Write("How many students ? ");
            parseIntOK = int.TryParse(Console.ReadLine(), out nbStudents);

            if (parseIntOK && nbStudents >= 0)
            {
                // Init Array of Students
                students = new Student[nbStudents];

                for (int i = 0; i < nbStudents; i++)
                {
                    Console.Write("Student's name ? ");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Error with input... program aborted");
            }

            Console.WriteLine("Enter a key to finish");
            Console.ReadLine();
        }
    }
}
