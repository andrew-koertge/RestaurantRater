using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allNums = { 1, 2, 3, 4, 5 };

            int index = 0;

            while (index <= 5)
            {
                Console.WriteLine($"Last index {allNums[index]}");
                index++;
            }
            Console.ReadLine();
        }
    }
}
