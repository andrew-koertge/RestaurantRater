using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge
{
    class Greeter
    {
        public void ReturnName(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }

        public void TimeOfDay()
        {
            if (DateTime.Now.Hour >= 1 && DateTime.Now.Hour <=12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (DateTime.Now.Hour >12 && DateTime.Now.Hour <=18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if (DateTime.Now.Hour >18 && DateTime.Now.Hour < 21)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Good night.");
            }
        }
    }
}
