using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter which day of the week it is.");
                string day = Console.ReadLine();
                DayoftheWeek dayoftheWeek = (DayoftheWeek)Enum.Parse(typeof(DayoftheWeek), day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        public enum DayoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
