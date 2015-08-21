using System;
using System.Threading;
using System.Globalization;

//Problem 5. The Biggest of 3 Numbers
//• Write a program that finds the biggest of three numbers.

//Examples:
//a       b       c       biggest
//5       2       2       5 
//-2      -2      1       1 
//-2      4       3       4 
//0       -2.5    5       5 
//-0.1    -0.5    -1.1    -0.1 

class The_Biggest_of_3_Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter value for the first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter value for the second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter value for the third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double greaterAmongFirstAndSecond = Math.Max(firstNumber, secondNumber);
        double biggerNumber = Math.Max(greaterAmongFirstAndSecond, thirdNumber);
        Console.WriteLine("The biggest number is {0}", biggerNumber);
    }
}

