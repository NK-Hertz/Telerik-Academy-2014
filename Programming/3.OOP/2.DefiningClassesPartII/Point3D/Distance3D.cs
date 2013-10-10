using System;

public static class Distance3D
{
    public static double CalcDistance(Point3D pointFirst, Point3D pointSec)
    {
        double distance = 0;
        distance = Math.Sqrt(Math.Pow(pointFirst.PointX - pointSec.PointX, 2) 
            + Math.Pow(pointFirst.PointY - pointSec.PointY, 2) 
            + Math.Pow(pointFirst.PointZ - pointSec.PointZ, 2));

        return distance;
    }
}