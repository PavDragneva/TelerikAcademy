using System;
/*•	Write methods that calculate the surface of a triangle by given:
           o	Side and an altitude to it;
           o	Three sides;
           o	Two sides and an angle between them;
         •	Use System.Math.*/
class TriangleSurface
{
    static double SurfaceTriangleA(double side, double atitude)
    {
        double surface = (side * atitude)/2;
        return surface;
    }
    static double SurfaceTriangleB(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        double temp = s * (s - a) * (s - b) * (s - c);
        double surface = Math.Sqrt(temp);
        return surface;
    }
   static double SurfaceTriangleC(double a, double b, double angle)
    {
        angle = angle * Math.PI / 180;
        double surface = (a * b * Math.Sin(angle))/2;
        return surface;
    }
    static void Main()
    {
        Console.Write(@"Chooce a method that calculate the surface of a triangle by:
      1.Side and an altitude to it;
      2.Three sides;
      3.Two sides and an angle between them;
Enter number(1-3): ");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("altitude = ");
            double alt = double.Parse(Console.ReadLine());
            double result = SurfaceTriangleA(a, alt);
            Console.WriteLine(result + "cm.");
        }
        else if(choice == 2)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double result = SurfaceTriangleB(a, b, c);
            Console.WriteLine(result + "cm.");
        }
        else if(choice == 3)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("angle = ");
            double angle = double.Parse(Console.ReadLine());
            double result = SurfaceTriangleC(a, b, angle);
            Console.WriteLine(result + "cm.");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}

