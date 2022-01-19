using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.firstName = "Example";
            //employee.lastName = "Student";
            //employee.SayName();

            IQuittable quittable = new Employee();

            Console.WriteLine("Do you wish to quit the company? Type \"true\" or \"false\"");
            bool quitting = Convert.ToBoolean(Console.ReadLine());

            if (quitting)
            {
                quittable.Quit();
            }
            else 
            { 
                Console.WriteLine("Thank You"); 
            }
            Console.ReadLine();
        }
    }
}
