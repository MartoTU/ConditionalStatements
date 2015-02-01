using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the biggest of five numbers by using only five if statements.
namespace _06.TheBigestofSixNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter five Numbers ");
            string a = Console.ReadLine();
            decimal firstNumber = decimal.Parse(a);
            string b = Console.ReadLine();
            decimal secondNumber = decimal.Parse(b);
            string c = Console.ReadLine();
            decimal thirdNumber = decimal.Parse(c);
            string d = Console.ReadLine();
            decimal fourthNumber = decimal.Parse(d);
            string e = Console.ReadLine();
            decimal fifthNumber = decimal.Parse(e);
            
            decimal theBiggest;
            if (firstNumber >= secondNumber)
            {
                theBiggest = firstNumber;
            }
            else
            {
                theBiggest = secondNumber;
            }
            if (thirdNumber >= theBiggest)
            {
                theBiggest = thirdNumber;
            }
            if (fourthNumber >= theBiggest)
            {
                theBiggest = fourthNumber;
            }
            if (fifthNumber >= theBiggest)
            {
                theBiggest = fifthNumber;
            }
            
            Console.WriteLine("The Biggest from these 5 numbers is: {0} !", theBiggest);
            Console.ReadLine();
        }
    }
}
