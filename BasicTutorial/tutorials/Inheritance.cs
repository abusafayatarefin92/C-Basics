using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.tutorials
{
    internal class Animal2
    {
        public string name;
        public int age;
        public string voice;
        public static int animalCount = 0;

        public void printDetails()
        {
            Console.WriteLine("Name: " + name + " " + " Age: " + age + " Voice: " + voice);
        }
    }

    class Tiger : Animal2
    {
        public string bred;

        public void sound()
        {
            Console.WriteLine("Tiger sound: roar");
        }

        public Tiger(string _name, int _age, string _voice, string _bred)
        {
            name = _name;
            age = _age;
            voice = _voice;
            bred = _bred;
        }
    }
    internal class Inheritance
    {
        //static void Main(string[] args)
        //{
        //    Tiger tiger = new Tiger("Maouy", 30, "Roar", "Bengal");
        //    tiger.printDetails();
        //    Console.WriteLine(tiger.bred);
        //    tiger.sound();
        //}
    }
}
