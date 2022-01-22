using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<string> firstNames = new List<string>() { "Joe", "Bill", "Sam", "Sally", "Joe", "Cole", "Phill", "Mary", "Jill", "Harry"};
            List<string> lastNames = new List<string>() { "Smith", "Cooper", "Gibbs", "Bolt", "Rector", "Spencer", "Crandell", "Mitchell", "Woods", "Colson" };
            List<int> IDs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Employee employee = new Employee();
                employee.firstName = firstNames[i];
                employee.lastName = lastNames[i];
                employee.Id = IDs[i];
                employees.Add(employee);
            }

            List<Employee> TempList = employees.Where(x => x.firstName == "Joe").ToList();
            
            List<Employee> TempList2 = employees.Where(x => x.Id > 5).ToList();

        }
        public struct Employee
        {
            public string firstName;
            public string lastName;
            public int Id;
        }
    }
}
