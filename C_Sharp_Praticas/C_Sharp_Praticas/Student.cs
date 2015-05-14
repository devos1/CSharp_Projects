using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Praticas
{
    public class Student
    {
        // PROPERTIES
        public String name { get; set; }
        public Double test1 { get; set; }
        public Double test2 { get; set; }

        /// <summary>
        /// DEFAULT CONSTRUCTOR
        /// </summary>
        public Student() 
        {
            name = "";
            test1 = 0;
            test2 = 0;
        }

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Test1"></param>
        /// <param name="Test2"></param>
        public Student(String Name, Double Test1, Double Test2)
        {
            name = Name;
            test1 = Test1;
            test2 = Test2;
        }

        /// <summary>
        /// Imprime les 2 notes avec la moyenne
        /// </summary>
        public void CompleteClassFinal(){
            //Console.WriteLine("Note 1 : {0} ; Note 2 : {1} => Moyenne : {2}",test1, test2, Math.Round(((test1+test2)/2),1,MidpointRounding.AwayFromZero));
            Console.WriteLine("{0,-20} {1,-8} {2, -8} {3,-10}", "Student", "Test 1", "Test 2", "Final Note");
            Console.WriteLine("{0,-20} {1,-8} {2, -8} {3,-10}", name, test1, test2, Math.Round(((test1 + test2) / 2), 1, MidpointRounding.AwayFromZero));
        }

        /// <summary>
        /// Retourne la moyenne des notes 
        /// </summary>
        /// <returns>AVG Note</returns>
        public Double ClassFinal()
        {
            return Math.Round(((test1 + test2) / 2), 1, MidpointRounding.AwayFromZero);
        }


    }
}
