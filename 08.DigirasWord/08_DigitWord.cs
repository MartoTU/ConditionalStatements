using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.
namespace DigirasWord
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter a one digit number (0-9), DIGIT = ");
            string digit = Console.ReadLine();
            string result;
            switch (digit)
            {
                case "0":
                    result = "ZERO";
                    break;
                case "1":
                    result = "ONE";
                    break;
                case "2":
                    result = "TWO";
                    break;
                case "3":
                    result = "THREE";
                    break;
                case "4":
                    result = "FOUR";
                    break;
                case "5":
                    result = "FIVE";
                    break;
                case "6":
                    result = "SIX";
                    break;
                case "7":
                    result = "SEVEN";
                    break;
                case "8":
                    result = "EIGHT";
                    break;
                case "9":
                    result = "NINE";
                    break;
                default:
                    result = "Not a digit !";
                    break;
            }
            Console.WriteLine("That digit is - {0} ", result);
            Console.ReadLine();
        }
    }
}
