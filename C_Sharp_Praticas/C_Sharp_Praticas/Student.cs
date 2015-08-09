using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Praticas
{
    public class Student
    {
        // ENUMS
        public enum StatStd
        {
            Ok,
            OkForOral,
            NotOk
        };

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

        /// <summary>
        /// Retourne la situation de l'elève (passe l'année ou pas ou si passe mais pour l'oral)
        /// </summary>
        /// <param name="std"></param>
        /// <returns></returns>
        public StatStd Passed(Student std)
        {
            double avgScore = (std.test1 + std.test2) / 2;

            if (avgScore >= 10)
            {
                return StatStd.Ok;
            }
            else if (avgScore >= 8)
            {
                return StatStd.OkForOral;
            }
            else
            {
                return StatStd.NotOk;
            }
        }

        #region EXERCICE 10
        // EXERCICE 10 - Création de varaibles et méthodes statiques
        private static int nbStudents = 0;
        private static double sumNotes = 0;

        /// <summary>
        /// Description : Ajoute la moyenne de chaque élève et incrémente le nb d'étudiants
        /// </summary>
        public void sumAvgNotes()
        {
            sumNotes += ClassFinal();
            nbStudents++;

        }
        /// <summary>
        /// Calcule la moyenne de la classe
        /// Return : 0 si erreur et la moyenne si ok
        /// </summary>
        /// <returns></returns>
        public static double ClassAVG()
        {
            if (nbStudents > 0)
            {
                return sumNotes / nbStudents;
            }
            else
            {
                return 0;
            }
        }

        public static void showClassAVG()
        {
            Console.WriteLine("Class AVG : {0}", Math.Round(ClassAVG(),2));
        }

        #endregion

        #region EXERCICE 11
        private static int nbStudentsWithPositive;

        public void assStdWithPositives()
        {
            if (test1 >= 10 || test2 >= 10)
            {
                nbStudentsWithPositive++;
            }
        }

        public static void showNbStdWithPositive()
        {
            Console.WriteLine("{0} student(s) have at least a positive score", nbStudentsWithPositive);
        }
        #endregion
    }
}
