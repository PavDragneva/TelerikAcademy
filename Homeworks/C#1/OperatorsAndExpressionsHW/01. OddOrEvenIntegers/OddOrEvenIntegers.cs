//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Insert integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Is Odd? - ");
        Console.WriteLine(number % 2 != 0);
    }
}

