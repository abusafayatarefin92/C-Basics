using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.delegateExample
{
    // Defining delegate
    public delegate int AddDelegate(int x, int y);
    public delegate void RectDel(double x, double y);
    internal class Delegate
    {
        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }
        //static void Main(string[] args)
        //{
        //    var result = AddNums(10, 40);
        //    Console.WriteLine(result);

        //    AddDelegate addNums = new AddDelegate(AddNums);
        //    var result2 = addNums(10, 40);
        //    Console.WriteLine(result2);

        //    Rectangle rect = new Rectangle();
        //    RectDel rectDel = new RectDel(rect.GetArea);
        //    rectDel += rect.GetParameter;
        //    rectDel.Invoke(17.77, 40.22);

        //    Console.ReadKey();
        //}
    }
}
