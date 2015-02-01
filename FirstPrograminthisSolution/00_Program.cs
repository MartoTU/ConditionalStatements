using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrograminthisSolution
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers");
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else
            {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(" {0} is bigger then {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine(" {0} is bigger then {1}", secondNumber, firstNumber);
            }
        }

    }
    }
}