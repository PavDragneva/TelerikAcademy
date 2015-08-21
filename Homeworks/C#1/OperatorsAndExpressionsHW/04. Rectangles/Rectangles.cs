//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;
using System.Threading;
using System.Globalization;
class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the width of the rectangle: ");
        double widthRectangle = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        double heightRectangle = double.Parse(Console.ReadLine());
        double rectangleArea = widthRectangle * heightRectangle;
        double rectanglePerimeter = 2 * (widthRectangle + heightRectangle);
        Console.WriteLine("The area of the rectangle is {0}cm. \nThe perimeter of the rectangle is {1}cm.", Math.Round(rectangleArea, 2), Math.Round(rectanglePerimeter, 2));
    }
}

