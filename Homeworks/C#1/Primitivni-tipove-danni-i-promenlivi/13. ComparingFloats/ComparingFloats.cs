//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
using System;
class ComparingFloats
{
    static void Main()
    {
        Console.Write("Number a is: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Number b is: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Abs(a - b) < 0.000001);
    }
}

