using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }

            else

            {
                Console.WriteLine("The number is odd");

        }
    }
    }
}
