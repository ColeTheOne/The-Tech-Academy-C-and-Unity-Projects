using System;

namespace BoolianLogicAssingment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int driverage = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            bool driverDUI = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int driverTicket = Convert.ToInt32(tickets);
            bool qualified = (driverage > 15 && driverDUI == false && driverTicket <= 3);
            Console.WriteLine("Quaified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
