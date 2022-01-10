using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_2
{
    public class Math
    {
        public int doMath(int num)
        {
            int result = num + 10;
            return result;
        }
        public int doMath (double num1)
        {
            double result = num1 + 10;
            int result1 = Convert.ToInt32(result);
            return result1;
        }

        public int doMath (string num3)
        {
            int num4 = Convert.ToInt32(num3);
            int result = num4 + 10;
            return result;
        }
    }
}
