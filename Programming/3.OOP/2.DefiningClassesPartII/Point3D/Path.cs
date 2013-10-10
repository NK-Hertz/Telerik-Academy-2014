using System;
using System.Collections.Generic;

public class Path
{
    public readonly List<Point3D> pointsList = new List<Point3D>();

    public void AddPoint(Point3D point)
    {
        this.pointsList.Add(point);
    }

    public void ClearPath()
    {
        this.pointsList.Clear();
    }
}