using System;

namespace whileDowhileAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you want to play a game? answer \"yes\" or \"no\"");
            string yesno = Console.ReadLine();
            do
            {
                switch (yesno)
                {
                    case "yes":
                        Console.WriteLine("Oh Good!");
                        break;
                    case "no":
                        Console.WriteLine("Are you sure? Let's try that again!");
                        Console.WriteLine("Do you want to play a game? answer \"yes\" or \"no\"");
                        yesno = Console.ReadLine();
                        if (yesno == "yes") 
                        { 
                            Console.WriteLine("Oh Good!"); 
                        }
                        break;
                    default:
                        Console.WriteLine("Please read the instructions and try again");
                        Console.WriteLine("Do you want to play a game? answer \"yes\" or \"no\"");
                        yesno = Console.ReadLine();
                        if (yesno == "yes")
                        {
                            Console.WriteLine("Oh Good!");
                        }
                        break;
                }
            }
            while (yesno != "yes");



            Console.WriteLine("Guess a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 3)
            {
                Console.WriteLine("That's wrong try agiain!");
                Console.WriteLine("Guess a number between 1 and 10");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You guessed 3! That's that correct number!!!");
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
    }
}
