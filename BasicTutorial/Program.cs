// See https://aka.ms/new-console-template for more information

using BasicTutorial.math;

namespace BasicTutorial
{
    class Program
    {

        public enum MailDetails
        {
            regularEmail = 2,
            regularAirEmail = 10,
            expressEmail = 56
        }
        static void Main(string[] args)
        {
            int age = 20;

            if (age <= 20)
            {
                Console.WriteLine("Kid");
            }
            else if (age >= 20 && age <= 50)
            {
                Console.WriteLine("Young");
            }
            else 
            {
                Console.WriteLine("You are an old man");
            }

            // Odd or Even
            int number = 50;

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else 
            {
                Console.WriteLine("Odd");
            }

            // Condition operator
            var output = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(output);

            // Switch statement
            var season = Season.Winter;

            switch (season) 
            {
                case Season.Summer:
                    Console.WriteLine("Summer");
                    break;
                case Season.Rainy:
                    Console.WriteLine("Rainy");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter");
                    break;
                case Season.Spring:
                    Console.WriteLine("Spring");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
