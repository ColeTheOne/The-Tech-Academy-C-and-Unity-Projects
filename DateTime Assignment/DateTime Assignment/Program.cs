using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("It is now {0}", time);
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            time = time.AddHours(num);
            Console.WriteLine("In {0} hours it will be {1}", num, time);
            Console.Read();
        }
    }
}
