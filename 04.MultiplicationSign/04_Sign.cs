﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.
namespace MultiplicationSign
{
    class Program
    {
       
            static void Main()
    {
        Console.WriteLine("Enter integers a,b and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a>0&&b>0&&c>0||a<0&&b<0&&c>0||a>0&&b<0&&c<0||
            a<0&&b>0&&c<0)
        {
            Console.WriteLine("+");
        }
        else if (a<0&&b>0&&c>0||a>0&&b<0&&c>0||a>0&&b>0&&c<0||
            a<0&&b<0&&c<0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine(0);
        }
        }
    }
}


