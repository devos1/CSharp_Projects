using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Praticas
{
    class Student
    {
        // PROPERTIES
        public String name { get; set; }
        public Double test1 { get; set; }
        public Double test2 { get; set; }

        // CONSTRUCTOR
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
            Console.WriteLine("Note 1 : {0} ; Note 2 : {1} => Moyenne : {2}",test1, test2, Math.Round(((test1+test2)/2),1,MidpointRounding.AwayFromZero));
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
