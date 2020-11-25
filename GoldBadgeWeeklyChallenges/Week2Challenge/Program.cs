using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Greeter greeter = new Greeter();
            greeter.ReturnName(name);

            greeter.SayGoodbye(name);

            int ageNeil = 22;
            int ageOwen = 19;
            bool isOlderNeil = ageNeil > ageOwen;
            if (isOlderNeil)
            {
                Console.WriteLine($"Tea");
            }
            else
            {
                Console.WriteLine("Coffee");
            }
        }
    }
}
