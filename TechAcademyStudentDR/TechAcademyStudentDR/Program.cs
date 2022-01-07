using System;

namespace TechAcademyStudentDR
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat is your name?");
            string stuName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string stuCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pgNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pgNum);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string stHelp = Console.ReadLine();
            bool studentHelp = Convert.ToBoolean(stHelp);
            Console.WriteLine("Where there any positive experiances you'd like to share? Please give specifics.");
            string stuExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specifc.");
            string stuFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string stuHrs = Console.ReadLine();
            int stuHours = Convert.ToInt32(stuHrs);
            Console.WriteLine("Thank you for you answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
