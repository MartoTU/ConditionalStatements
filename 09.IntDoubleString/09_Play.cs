using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.
namespace IntDoubleString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, choose a type of your variable !");
            Console.Write(@"For ""int"" enter number 1,for ""double"" enter number 2 or for ""string"" enter number 3!Please, enter a number: ");
            string typeVariable = Console.ReadLine();

            switch (typeVariable)
            {
                case "1":
                    Console.Write("Enter value for your integer, INT = ");
                    string inputStr = Console.ReadLine();
                    int numberInt = int.Parse(inputStr);
                    Console.WriteLine("The result is: {0} !", (numberInt + 1));
                    break;
                case "2":
                    Console.Write("Enter value for your double, DOUBLE = ");
                    inputStr = Console.ReadLine();
                    double numberDouble = double.Parse(inputStr);
                    Console.WriteLine("The result is: {0} !", (numberDouble + 1));
                    break;
                case "3":
                    Console.Write("Enter value for your string, STRING: ");
                    inputStr = Console.ReadLine();
                    Console.WriteLine("The result is: {0} !", inputStr + '*');
                    break;
                default:
                    Console.WriteLine("Error - Invalid Input !!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
