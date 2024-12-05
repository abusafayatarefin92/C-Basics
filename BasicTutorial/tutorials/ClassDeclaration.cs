using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.tutorials 
{ 
    public class Person2
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
    
    internal class ClassDeclaration
    {
        //static void Main(string[] args)
        //{
        //    var male = new Person2();
        //    male.firstName = "Jhon";
        //    male.lastName = "Doe";
        //    male.Introduce();
        //}
    }
}

