using System;
using System.Collections.Generic;

namespace Interation_Assignment_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "Hello, ", "Hi, ", "Hey, " };

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array1[i] + name;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            while (age < 18)
            {
                Console.WriteLine("You are not old enough to run this program.\nPlease get someone else to help you and try again.");
                Console.WriteLine("What is your age?");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thank you.");
            Console.WriteLine("Please enter the nuber of pizzas you would like to order from wholesale pizza house.");
            int pizzaOrder = Convert.ToInt32(Console.ReadLine());

            while (pizzaOrder <= 9)
            {
                Console.WriteLine("You must order at least ten pizzas to place an order with wholesale pizza house.");
                Console.WriteLine("Please review your order and try again.");
                Console.WriteLine("How many pizzas would you like to order?");
                pizzaOrder = Convert.ToInt32(Console.ReadLine());
            }

            string[] toppings = { "Bacon", "Pepperoni", "Mushrooms", "Olives", "Onions" };
            Console.WriteLine("Please select your topping. You may only select one topping");
            string userSelect = Console.ReadLine();

            for (int i = 0; i < toppings.Length; i++)
            {
                if (toppings[i] == userSelect)
                {
                    Console.WriteLine("You have seleted topping number: " + i);
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("The topping you have selected is not avalible. Please try again");
                    Console.WriteLine("Please select your topping. You may only select one topping");
                    userSelect = Console.ReadLine();
                    i = -1;
                }
            }

            string[] cheeses = { "Jack", "Mozzarella", "Cheddar", "Jack" };
            Console.WriteLine("We will now select a cheese for your pizzas");

            for (int i = 0; i < cheeses.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < cheeses.Length; j++)
                {
                    if (i != j && cheeses[i] == cheeses[j])
                    {
                        Console.WriteLine("The item " + cheeses[i] + " appears twice in the list");
                        count++;
                        break;
                    }
                }
                if (count > 0)
                {
                    break;
                }
            }

            Console.WriteLine("What cheese would you like?");
            string cheeseSelect = Console.ReadLine();

            for (int i = 0; i < cheeses.Length; i++)
            {
                if (cheeses[i] == cheeseSelect)
                {
                    Console.WriteLine("You have selected cheese number: " + i);
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("The topping you have selected is not avalible. Please try again");
                    Console.WriteLine("Please select your topping. You may only select one topping");
                    cheeseSelect = Console.ReadLine();
                    i = -1;
                }
            }

            List<string> Sauces = new List<string>() { "Red", "White", "Blonde", "Red", "BBQ" };
            List<int> vs = new List<int>();

            foreach (string sauce in Sauces)
            {
                int count = 0;
                foreach (string sauce2 in Sauces)
                {
                    if (sauce2 == sauce)
                    {
                        count++;
                    }
                }
                vs.Add(count);
            }

            Console.WriteLine("Here is a list of avalible Sauces:");

            if (vs[0] > 1)
            {
                Console.WriteLine(Sauces[0] + "- This item appears twice");
            }
            else
            {
                Console.WriteLine(Sauces[0] + "-This item does not appear twice");
            }

            if (vs[1] > 1)
            {
                Console.WriteLine(Sauces[1] + "- This item appears twice");
            }
            else
            {
                Console.WriteLine(Sauces[1] + "-This item does not appear twice");
            }

            if (vs[2] > 1)
            {
                Console.WriteLine(Sauces[2] + "- This item appears twice");
            }
            else
            {
                Console.WriteLine(Sauces[2] + "-This item does not appear twice");
            }

            if (vs[3] > 1)
            {
                Console.WriteLine(Sauces[3] + "- This item appears twice");
            }
            else
            {
                Console.WriteLine(Sauces[3] + "-This item does not appear twice");
            }

            if (vs[4] > 1)
            {
                Console.WriteLine(Sauces[4] + "- This item appears twice");
            }
            else
            {
                Console.WriteLine(Sauces[4] + "-This item does not appear twice");
            }

            Console.WriteLine("Thank you for your order");
            Console.ReadLine();
        }
    }
}
