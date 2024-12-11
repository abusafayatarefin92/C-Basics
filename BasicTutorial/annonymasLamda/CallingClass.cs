using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.annonymasLamda
{
    public delegate string GrettingsDel(string name);
    internal class CallingClass
    {
        //static void Main(string[] args)
        //{
        //    //GrettingsDel greetDel = new GrettingsDel(AnnonymasMethods.Grettings);
        //    //GrettingsDel greetDel = delegate (string name)
        //    //{
        //    //    return "Hello " + name + " have a good day!";
        //    //};
        //    GrettingsDel greetDel = (name) =>
        //    {
        //        return "Hello " + name + " have a good day!";
        //    };
        //    string greetStr = greetDel.Invoke("Jhon Doe");
        //    Console.WriteLine(greetStr);

        //    Console.ReadKey();
        //}
    }
}
