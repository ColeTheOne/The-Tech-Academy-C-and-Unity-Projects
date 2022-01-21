using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Workplace operator == (Workplace workplace, Employee employee)
        {
            int count = 0;
            foreach (Employee entery in workplace.Employees)
            {
                
                if (entery.Id == employee.Id)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                workplace.Employees.Add(employee);
            }
            return workplace;
        }
        public static Workplace operator != (Workplace workplace, Employee employee)
        {
            workplace.Employees.Remove(employee);
            return workplace;
        }
    }
}
