using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
namespace SortThreeNumbers
{
    class Sort
    {
        static void Main()
        {
            Console.Write("Please, enter the First number : ");
            string numberStr = Console.ReadLine();
            decimal firstNumber = decimal.Parse(numberStr);
            Console.Write("Enter the Second number : ");
            numberStr = Console.ReadLine();
            decimal secondNumber = decimal.Parse(numberStr);
            Console.Write("Enter the Third number : ");
            numberStr = Console.ReadLine();
            decimal thirdNumber = decimal.Parse(numberStr);

            decimal theBiggest = 0;
            decimal theMiddle = 0;
            decimal theSmallest = 0;
            if (firstNumber >= thirdNumber && secondNumber >= thirdNumber)
            {
                theSmallest = thirdNumber;
                if (firstNumber >= secondNumber)
                {
                    theBiggest = firstNumber;
                    theMiddle = secondNumber;
                }
                else
                {
                    theBiggest = secondNumber;
                    theMiddle = firstNumber;
                }
            }
            else if (firstNumber >= secondNumber && secondNumber <= thirdNumber)
            {
                theSmallest = secondNumber;
                if (firstNumber >= thirdNumber)
                {
                    theBiggest = firstNumber;
                    theMiddle = thirdNumber;
                }
                else
                {
                    theBiggest = thirdNumber;
                    theMiddle = firstNumber;
                }
            }
            else
            {
                theSmallest =firstNumber;
                if (secondNumber >= thirdNumber)
                {
                    theBiggest = secondNumber;
                    theMiddle = thirdNumber;
                }
                else
                {
                    theBiggest = thirdNumber;
                    theMiddle = secondNumber;
                }
            }
            Console.WriteLine("The three sorted numbers are: {0}, {1}, {2} !",theBiggest, theMiddle, theSmallest);
            Console.ReadLine();
        }
    }
}
