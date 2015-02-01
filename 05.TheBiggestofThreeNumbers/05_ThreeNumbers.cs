using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the biggest of three numbers.
namespace TheBiggestofThreeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three Numbers: ");
            string a = Console.ReadLine();
            decimal firstNumber = decimal.Parse(a);
            string b = Console.ReadLine();
            decimal secondNumber = decimal.Parse(b);
            string c = Console.ReadLine();
            decimal thirdNumber = decimal.Parse(c);

            decimal Biggest;
            if (firstNumber >= secondNumber)
            {
                if (firstNumber >=thirdNumber)
                {
                    Biggest = firstNumber;
                }
                else
                {
                    Biggest = thirdNumber;
                }
            }
            else
            {
                if (secondNumber >= thirdNumber)
                {
                    Biggest = secondNumber;
                }
                else
                {
                    Biggest = thirdNumber;
                }
            }
            Console.WriteLine("The Biggest from these 3 numbers is : {0} !", Biggest);

            Console.ReadLine();
        }
    }
}
