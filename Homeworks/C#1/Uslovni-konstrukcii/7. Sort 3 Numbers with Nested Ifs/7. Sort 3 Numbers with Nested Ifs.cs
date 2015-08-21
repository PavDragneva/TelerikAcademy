using System;
using System.Threading;
using System.Globalization;

//Problem 7. Sort 3 Numbers with Nested Ifs
//• Write a program that enters 3 real numbers and prints them sorted in descending order. ◦ Use nested  if  statements.
//Note: Don’t use arrays and the built-in sorting functionality.
//Examples:
//a       b       c       result
//5       1       2       5 2 1 
//-2      -2      1       1 -2 -2 
//-2      4       3       4 3 -2 
//0       -2.5    5       5 0 -2.5 
//-1.1    -0.5    -0.1    -0.1 -0.5 -1.1 
//10      20      30      30 20 10 
//1       1       1       1 1 1 

class Sort_3_Numbers_with_Nested_Ifs
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
        double mask;
        if (secondNumber < thirdNumber)
        {
            mask = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = mask;
            if (firstNumber < secondNumber)
            {
                mask = firstNumber;
                firstNumber = secondNumber;
                secondNumber = mask;
                if (secondNumber < thirdNumber)
                {
                    mask = thirdNumber;
                    thirdNumber = secondNumber;
                    secondNumber = mask;
                }
            }
        }
        else
        {
            if (firstNumber < secondNumber)
            {
                mask = firstNumber;
                firstNumber = secondNumber;
                secondNumber = mask;
                if (secondNumber < thirdNumber)
                {
                    mask = thirdNumber;
                    thirdNumber = secondNumber;
                    secondNumber = mask;
                }
            }
        }
        Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
    }
}




