using System;
using System.Collections.Generic;
public class Path
{
    private List<Point3D> pathPoints;

    public List<Point3D> PathPoints { get; set; }

    public void AddPoint(Point3D point)
    {
        pathPoints.Add(point);
    }
}