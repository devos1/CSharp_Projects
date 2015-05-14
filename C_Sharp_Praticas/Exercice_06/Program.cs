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
            double score;
            Student student;
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
                    // Create student tmp
                    student = new Student();
                    
                    // Ask infos to user and add to student object
                    Console.Write("Student's name ? ");
                    student.name = Console.ReadLine();

                    // Ask for score 1
                    do
                    {
                        Console.Write("Score Test 1 : ");
                        parseIntOK = double.TryParse(Console.ReadLine(), out score);
                        student.test1 = score;
                    } while (!parseIntOK);

                    // Ask for score 2
                    do
                    {
                        Console.Write("Score Test 2 : ");
                        parseIntOK = double.TryParse(Console.ReadLine(), out score);
                        student.test2 = score;
                    } while (!parseIntOK);

                    // Add student to array
                    students[i] = student;
                }

                // Sort by Name and display into Console
                sortArrayByName(students);
                DisplayValues(students);
            }
            else
            {
                Console.WriteLine("Error with input... program aborted");
            }

            Console.WriteLine("\nEnter a key to finish");
            Console.ReadLine();

        }

        /// <summary>
        /// Sort Array by Name using delegate
        /// </summary>
        /// <param name="students"></param>
        private static void sortArrayByName(Student[] students){
            Array.Sort(students, delegate(Student std1, Student std2)
            {
                return std1.name.CompareTo(std2.name);
            });
        }

        /// <summary>
        /// Print data to Console for Student's array
        /// </summary>
        /// <param name="arr"></param>
        private static void DisplayValues(Student[] arr)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("{0,-20} {1,-8}", "Student", "Final Score");
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0,-25} {1}", arr[i].name, arr[i].ClassFinal());
            }
        }
    }
}
