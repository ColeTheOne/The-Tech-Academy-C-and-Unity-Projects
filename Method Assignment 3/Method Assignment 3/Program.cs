using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number (you may leave this blank if you wish):");
            string Number = Console.ReadLine();

            try
            {
                int num2 = Convert.ToInt32(Number);
                int sum = math.doMath(num1, num2);
                Console.WriteLine("Your two numbers added together equals: {0}", sum);
            }
            catch (FormatException)
            {
                int sum = math.doMath(num1);
                Console.WriteLine("Your two numbers added together equals: {0}", sum);
            }
          
            Console.ReadLine();
        }
    }
}
