using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.tutorials
{
    class Animal
    {
        public string name;
        public int age;
        public string voice;
        public static int animalCount = 0;

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name + " " + " Age: " + age + " Voice: " + voice);
        }

        public Animal(string _name, int _age, string _voice)
        {
            name = _name;
            age = _age;
            voice = _voice;
            animalCount++;
        }
    }
    internal class ContructorAndAccessModifier
    {
        //static void Main(string[] args)
        //{
        //    Animal animal = new Animal("Tiger", 20, "Roar");
        //    animal.printDetails();
        //    Console.WriteLine();

        //    Animal animal2 = new Animal("Lion", 22, "Ruru");
        //    animal2.printDetails();
        //    Console.WriteLine();

        //    Animal animal3 = new Animal("Cow", 30, "Hamba");
        //    animal3.printDetails();
        //    Console.WriteLine();

        //    Console.WriteLine("Number of animal: " + Animal.animalCount);
        //}
    }
}
