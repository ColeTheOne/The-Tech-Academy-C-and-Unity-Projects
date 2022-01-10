using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();
            
            int num1 = math.doMath(5);
            Console.WriteLine("Five plus ten is {0}", num1);

            //Math math2 = new Math();
            int num2 = math.doMath(5.5);
            Console.WriteLine("Five and a half plus ten is {0}", num2);
            try
            {
                int num3 = math.doMath("5");
                Console.WriteLine("Five plus five is {0}", num3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not complete format");
            }
        

            Console.ReadLine();
        }
    }
}
