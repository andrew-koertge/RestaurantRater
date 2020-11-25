using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Drew";
            string lastName = "Koertge";
            int age = 33;
            string[] favMovies = new string[] { "Office Space", "Deadpool", "Star Wars", "Shrek" };
            List<DateTime> dateList = new List<DateTime>
            {
                DateTime.Now
            };

            Console.WriteLine(age + 7);

            int hoursOfSleep = 8;
            if (hoursOfSleep >= 10)
            {
                Console.WriteLine("Wow. That's a lot of sleep!");
            }
            else if (hoursOfSleep >= 8 && hoursOfSleep < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (hoursOfSleep > 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("Bummer");
            }

            string howIsYourDay = "Good";
            switch (howIsYourDay)
            {
                case "Great":
                    Console.WriteLine("Share some of that will ya?");
                    break;
                case "Good":
                    Console.WriteLine("Good good or good okay?");
                    break;
                case "Okay":
                    Console.WriteLine("Okay.");
                    break;
                case "Bad":
                    Console.WriteLine("Sorry bud.");
                    break;
                case ":(":
                    Console.WriteLine("Who hurt you?");
                    break;
                default:
                    break;
            }
        }
    }
}
