using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    public class Calculator
    {
        public int doMath1(Num num)
        {
            int Result = num * 2;
            return Result;
        }

        public int doMath2(Num num)
        {
            int Result = num + 10;
            return Result;
        }

        public int doMath3(Num num)
        {
            int Result = num - 15;
            return Result;
        }

        //public int Result {get; set;}
    }
}
