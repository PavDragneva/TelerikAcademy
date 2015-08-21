//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;
using System.Threading;
using System.Globalization;
class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter your weight: ");
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = 0.17*weightEarth;
        Console.WriteLine("Your weight on the Moon would be {0}kg", Math.Round(weightMoon, 2));
    }
}

