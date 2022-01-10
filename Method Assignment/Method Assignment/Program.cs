using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a Number.");
            int Num = Convert.ToInt32(Console.ReadLine());

            Calculator cal = new Calculator();

            int Num1 = cal.doMath1(Num);
            int Num2 = cal.doMath2(Num);
            int Num3 = cal.doMath3(Num);

            Console.WriteLine("Your number times 15 is " + Num1);
            Console.WriteLine("Your number plus 10 is " + Num2);
            Console.WriteLine("Your number divided by 2 is " + Num3);
            Console.ReadLine();
        }
    }
}
