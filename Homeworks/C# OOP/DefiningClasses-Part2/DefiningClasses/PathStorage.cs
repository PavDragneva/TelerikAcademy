using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
public static class PathStorage
{
    public static List<Point3D> GetFromText()
    {
        List<Point3D> points = new List<Point3D>();
        StreamReader reader = new StreamReader("TestPoints.txt");
        int[] arr = new int[3];
        string line = reader.ReadLine();
        while (line != null)
        {
            arr = line.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Point3D point = new Point3D(line[0], line[1], line[2]);
            points.Add(point);
            line = reader.ReadLine();
        }
        return points;
    }
    public static void AddToText(Point3D point)
    {
        StreamWriter writer = new StreamWriter("Points.txt");
        writer.WriteLine(point);
        writer.Flush();
        Console.WriteLine("File written!");
    }
}