using System;
using System.Collections.Generic;
class Start
{
    static void Main()
    {
        //Some tests. You can change values to check the correct work of the program.
        Point3D point = new Point3D(1, 9, 2);
        string pointToString = point.ToString();
        Console.WriteLine("Printing a point: {0}", pointToString);

        Point3D a = new Point3D(8, 4, 2);
        Point3D b = new Point3D(1, 9, 3);
        double distance = CalculateDisatnce.DistanceCalculator(a, b);
        Console.WriteLine("The distance betweem point A and point B is {0}", distance);

        List<Point3D> listPoints = new List<Point3D>();
        listPoints.Add(point);
        listPoints.Add(a);
        listPoints.Add(b);

        PathStorage.AddToText(point);
    }
}

