//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//(heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the 
//CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) 
//stored in an array.
using System;
class Test
{
    static void Main()
    {
        Shape[] arr = new Shape[]
        {
            new Rectangle(3.5, 4),
            new Square(5, 5),
            new Triangle(3, 2),
            new Rectangle(1.2, 10),
            //Height and width are different, but the surface will be calculate with the value of the width, because the shape is square.
            new Square(3, 5)
        };
        foreach(Shape shape in arr)
        {
            double surface = shape.CalculateSurface();
            string type = shape.GetType().ToString();
            Console.WriteLine("The surface of the {0} is {1}", type, surface);
        }
    }
}