//Write an expression that checks for given integer if its third digit from right-to-left is 7.
using System;
class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        number /= 100;
        Console.WriteLine(number % 10 == 7);
    }
}

