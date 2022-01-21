using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    public class Workplace
    {
        public List<Employee> Employees { get; set; }

        public void printNames()
        {
            Console.WriteLine("List of current employees:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
