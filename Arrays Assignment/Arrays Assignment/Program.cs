using System;
using System.Collections.Generic;

namespace Arrays_Assignment
{
    internal class Program
    {
        static void Main()
        {
            string[] greatings = { "Hello", "Hi!", "Hey", "What's up?" };

            Console.WriteLine("Please select an index of the string array between 0 and 3");
            string userSelect = Console.ReadLine();

            switch (userSelect)
            {
                case "0":
                    Console.WriteLine(greatings[0]);
                    break;
                case "1":
                    Console.WriteLine(greatings[1]);
                    break;
                case "2":
                    Console.WriteLine(greatings[2]);
                    break;
                case "3":
                    Console.WriteLine(greatings[3]);
                    break;
                default:
                    Console.WriteLine("I'm sorry that index does not exist");
                    break;
            }

            int[] intArray = { 75, 89, 43, 52 };

            Console.WriteLine("Please select an index of the int array between 0 and 3");
            string userSelect2 = Console.ReadLine();

            switch (userSelect2)
            {
                case "0":
                    Console.WriteLine(intArray[0]);
                    break;
                case "1":
                    Console.WriteLine(intArray[1]);
                    break;
                case "2":
                    Console.WriteLine(intArray[2]);
                    break;
                case "3":
                    Console.WriteLine(intArray[3]);
                    break;
                default:
                    Console.WriteLine("I'm sorry that index does not exist");
                    break;
            }

            List<string> list1 = new List<string>();
            list1.Add("Goodbye");
            list1.Add("Bye");
            list1.Add("Good Day");
            list1.Add("See you later");

            Console.WriteLine("Please select an index of the string List between 0 and 3");
            string userSelect3 = Console.ReadLine();

            switch (userSelect3)
            {
                case "0":
                    Console.WriteLine(list1[0]);
                    break;
                case "1":
                    Console.WriteLine(list1[1]);
                    break;
                case "2":
                    Console.WriteLine(list1[2]);
                    break;
                case "3":
                    Console.WriteLine(list1[3]);
                    break;
                default:
                    Console.WriteLine("I'm sorry that index does not exist");
                    break;
            }

            Console.ReadLine();
        }
    }
}
