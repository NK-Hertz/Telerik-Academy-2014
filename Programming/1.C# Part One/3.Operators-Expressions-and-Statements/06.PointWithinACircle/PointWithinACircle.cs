using System;

class PointWithinACircle
{
    //Write an expression that checks if given point (x,  y) is within a circle 
    //K(O, 5).

    static void Main()
    {
        decimal pointX = 2.0m;
        decimal pointY = -3.3m;
        decimal centerX = 0.0m;
        decimal centerY = 1.0m;
        decimal resultX = (pointX - centerX) * (pointX - centerX);
        decimal resultY = (pointY - centerY) * (pointY - centerY);
        decimal radius = 5;
        decimal finalResult = resultX + resultY;
        bool isWithinCircle = finalResult < radius * radius;
        Console.WriteLine(isWithinCircle);
    }
}