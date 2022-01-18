using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_5
{
    internal class Math
    {
        public void doMath (int num)
        {
            int result = num / 2;
            Console.WriteLine("Your number divided by 2 is " + result);
        }

        public void doMath (string num)
        {
            int number = Convert.ToInt32(num);
            int result = number * 2;
            Console.WriteLine("Your number times 2 is " + result);
        }
    }
}
