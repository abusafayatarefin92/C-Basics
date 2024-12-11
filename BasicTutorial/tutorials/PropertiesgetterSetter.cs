using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTutorial.tutorials
{
    class Income
    {
        private int _income = 10000;

        public int income
        {
            get
            {
                return _income;
            }

            set
            {
                //_income = value;
                if (value <= 0)
                {
                    _income = 0;
                }
                else if (value > 10000)
                {
                    _income = 10000;
                }
                else
                {
                    _income = value;
                }
            }
        }

        public void debit(int moneySpent)
        {
            _income = _income - moneySpent;
        }
    }
    internal class PropertiesgetterSetter
    {
        //static void Main(string[] args)
        //{
        //    //DateTime currentTime = DateTime.Now;
        //    //Console.WriteLine(currentTime);
        //    //Console.ReadKey();

        //    Income amountLeft = new Income();
        //    amountLeft.debit(100);
        //    amountLeft.income -= 10500;
        //    Console.WriteLine(amountLeft.income);
        //    amountLeft.income += 15000;
        //    Console.WriteLine(amountLeft.income);
        //    Console.ReadKey();
        //}
    }
}
