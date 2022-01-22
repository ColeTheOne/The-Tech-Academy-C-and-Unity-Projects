using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Wrench", "Hammer", "Lunch", "Time Card"};
            
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { 53, 91, 26, 26 };

            Console.WriteLine("Here are all the things:");
            foreach (string Thing in employee1.Things)
            {
                Console.WriteLine(Thing);
            }
            foreach (int Thing in employee2.Things)
            {
                Console.WriteLine(Thing);
            }
            Console.ReadLine();
        }
    }
}
