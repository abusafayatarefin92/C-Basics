using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.delegateExample
{
    internal class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of rectengle: " + width * height);
        }

        public void GetParameter(double width, double height)
        {
            Console.WriteLine("Parameter of rectengle: " + 2 * (width + height));
        }
    }
}
