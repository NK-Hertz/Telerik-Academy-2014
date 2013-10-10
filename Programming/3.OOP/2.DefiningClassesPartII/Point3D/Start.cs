using System;
using System.Collections.Generic;

public class Start
{
    public static void Main()
    {
        Point3D pointFirst = new Point3D(1, 2, 3);
        Point3D pointSec = new Point3D(3, 4, 5);
        Console.WriteLine(Distance3D.CalcDistance(pointFirst, pointSec));

        Path firstPath = new Path();
        firstPath.AddPoint(pointSec);
        firstPath.AddPoint(pointFirst);
        firstPath.AddPoint(pointSec);

        PathStorage.SavePath(firstPath);
        List<Path> pathList = PathStorage.LoadPath();
        foreach (var path in pathList)
        {
            Console.WriteLine("--------------");
            foreach (var pointers in path.pointsList)
            {
                Console.WriteLine(pointers);
            }

            Console.WriteLine("--------------");
        }

    }
}