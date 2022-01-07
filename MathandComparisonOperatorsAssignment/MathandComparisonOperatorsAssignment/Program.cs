using System;

namespace MathandComparisonOperatorsAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Progam");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is Person 1's hourly pay rate?");
            string hrRate1 = Console.ReadLine();
            double hourRate1 = Convert.ToDouble(hrRate1);
            Console.WriteLine("How many hours does Person 1 work per week?");
            string hrWeek1 = Console.ReadLine();
            double hourWeek1 = Convert.ToDouble(hrWeek1);
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is Person 2's hourly pay rate?");
            string hrRate2 = Console.ReadLine();
            double hourRate2 = Convert.ToDouble(hrRate2);
            Console.WriteLine("Houw many hours does Person 2 work per week?");
            string hrWeek2 = Console.ReadLine();
            double hourWeek2 = Convert.ToDouble(hrWeek2);
            Console.WriteLine("Annual salary of person 1:");
            double anSal1 = hourRate1 * hourWeek1 * 52;
            Console.WriteLine(anSal1);
            Console.WriteLine("Annual salary of person 2:");
            double anSal2 = hourRate2 * hourWeek2 * 52;
            Console.WriteLine(anSal2);
            bool compair = anSal1 > anSal2;
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(compair);
            Console.ReadLine();
        }
    }
}
