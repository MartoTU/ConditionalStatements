using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
namespace ExchangeifGrater
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the value for the first number: ");
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            Console.WriteLine("Enter the value for the second number: ");
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);

            if (firstNumber > secondNumber)
            {
                firstNumber += secondNumber;
                firstNumber = secondNumber - firstNumber;
                secondNumber = secondNumber - firstNumber;
            }
            Console.WriteLine("The changed values of two numbers are: {0} {1}!", firstNumber, secondNumber);
            Console.ReadLine();
        }
    }
}
