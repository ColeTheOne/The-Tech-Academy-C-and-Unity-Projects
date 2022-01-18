using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please write a number");
            int num = Convert.ToInt32(Console.ReadLine());

            math.doMath(num);

            Console.WriteLine("Please enter another number");
            string num2 = Console.ReadLine();

            math.doMath(num2);

            Console.ReadLine();
        }
    }
}
