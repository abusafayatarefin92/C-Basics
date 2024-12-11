// See https://aka.ms/new-console-template for more information

using BasicTutorial.annonymasLamda;
using BasicTutorial.delegateExample;
using BasicTutorial.math;
using BasicTutorial.polymorphism;

namespace BasicTutorial
{
    public delegate string GrettingsDel(string name);
    class Program
    {
        static void Main(string[] args) 
        {
            //GrettingsDel greetDel = new GrettingsDel(AnnonymasMethods.Grettings);
            //GrettingsDel greetDel = delegate (string name)
            //{
            //    return "Hello " + name + " have a good day!";
            //};
            GrettingsDel greetDel = (name)=>
            {
                return "Hello " + name + " have a good day!";
            };
            string greetStr = greetDel.Invoke("Jhon Doe");
            Console.WriteLine(greetStr);

            Console.ReadKey();
        }
    }
}
