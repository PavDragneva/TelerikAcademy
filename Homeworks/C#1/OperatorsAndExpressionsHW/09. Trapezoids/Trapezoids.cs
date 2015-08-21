//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;
using System.Threading;
using System.Globalization;
class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("The value of the side a is ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("The value of the side b is ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("The value of the height h is ");
        double h = double.Parse(Console.ReadLine());
        double areaTrapezoids = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoids is {0}", Math.Round(areaTrapezoids, 2));
    }
}

