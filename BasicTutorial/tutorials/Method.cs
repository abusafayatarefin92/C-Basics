using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.tutorials
{
    internal class Method
    {
        //static void Main(string[] args)
        //{
        //    int myAge = age(2024, 1992);

        //    if (myAge > 30)
        //        Console.WriteLine("You should be married!");

        //    else
        //        Console.WriteLine("Other");

        //    Console.ReadLine();
        //}

        public static int age(int currentYear, int dateOfBirth)
        {
            return currentYear - dateOfBirth;
        }
    }
}
