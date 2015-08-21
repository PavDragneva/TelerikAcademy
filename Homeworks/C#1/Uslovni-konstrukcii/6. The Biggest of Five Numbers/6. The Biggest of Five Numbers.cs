using System;
using System.Threading;
using System.Globalization;

//Problem 6. The Biggest of Five Numbers
//• Write a program that finds the biggest of five numbers by using only five if statements.

//Examples:
//a       b       c       d       e       biggest
//5       2       2       4       1       5 
//-2      -22     1       0       0       1 
//-2      4       3       2       0       4 
//0       -2.5    0       5       5       5 
//-3      -0.5    -1.1    -2      -0.1    -0.1 

class The_Biggest_of_Five_Numbers
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
        Console.Write("Enter value for the fourth real number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter value for the fifth real number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        double greaterAmongFirstAndSecond = Math.Max(firstNumber, secondNumber);
        double greaterAmongThirdAndFourth = Math.Max(thirdNumber, fourthNumber);
        double biggestNumber;
        if(greaterAmongFirstAndSecond > greaterAmongThirdAndFourth)
        {
            biggestNumber= Math.Max(greaterAmongFirstAndSecond, fifthNumber);
        }
        else
        {
            biggestNumber = Math.Max(greaterAmongThirdAndFourth, fifthNumber);
        }
        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}

