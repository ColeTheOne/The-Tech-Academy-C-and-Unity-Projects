using System;


namespace BrancingAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pack Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the height of your package?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the lenth of your package?");
                double lenth = Convert.ToDouble(Console.ReadLine());
                double dimensions = height + lenth;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double quote = ((height * lenth * weight) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
