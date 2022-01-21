using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Workplace workplace = new Workplace();
            workplace.Employees = new List<Employee>();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("Please enter the name of Employee 1:");
            employee1.Name = Console.ReadLine();
            Console.WriteLine("Please enter Employee 1's ID:");
            employee1.Id = Convert.ToInt32(Console.ReadLine());
            workplace = workplace == employee1;

            Console.WriteLine("Please enter the name of Employee 2:");
            employee2.Name = Console.ReadLine();
            Console.WriteLine("Please enter Employee 2's ID:");
            employee2.Id = Convert.ToInt32(Console.ReadLine());
            workplace = workplace == employee2;

            workplace.printNames();
            Console.ReadLine();
        }
    }
}
