using System;
using System.Threading;
using System.Globalization;

//Problem 1. Exchange If Greater
//• Write an if-statement that takes two double variables a and b and
//exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.

//Examples:
//a       b       result
//5       2       2 5 
//3       4       3 4 
//5.5     4.5     4.5 5.5 

class Exchange_If_Greater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        if(a > b)
        {
            double mask = a;
            a = b;
            b = mask;
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
    }
}

