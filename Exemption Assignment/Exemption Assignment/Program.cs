using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int>() { 61, 52, 78, 100, 39, 267 };

                Console.WriteLine("Please pick a number to divide the other numbers by.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Here's the results:");

                foreach (int num in Numbers)
                {
                    int result = num / userNum;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please, selcet a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }
         
            Console.WriteLine("We will now continue with the rest of the program.");
           
            Console.ReadLine();
        }
    }
}
