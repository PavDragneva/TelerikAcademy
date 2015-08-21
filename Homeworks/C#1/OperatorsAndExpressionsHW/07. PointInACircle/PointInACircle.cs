//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;
using System.Threading;
using System.Globalization;
class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the value of x - ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of y - ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("The point is inside the circle - " + (!(x > 2 || x < -2) && !(y > 2 || y < -2)));  
    }
}

