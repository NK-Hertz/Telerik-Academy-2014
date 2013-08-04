using System;
using System.Drawing;

class WithinCirlceAndOutOfRectangle
{
    //Write an expression that checks for given point (x, y) if it is within the
    //circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, 
    //height=2).
    static void Main()
    {
        decimal pointX = 1.7m;
        decimal pointY = 2.5m;
        decimal centerX = 1.0m;
        decimal centerY = 1.0m;
        decimal resultX = (pointX - centerX) * (pointX - centerX);
        decimal resultY = (pointY - centerY) * (pointY - centerY);
        decimal radius = 3;
        decimal finalResult = resultX + resultY;

        bool isWithinCircle = finalResult < radius * radius;

        decimal rectTopX = -1.0m;
        decimal rectTopY = 1.0m;
        decimal rectWidth = 6.0m;
        decimal rectHeight = 2.0m;
        decimal rectBottomX = rectTopX + rectWidth;
        decimal rectBottomY = rectTopY - rectHeight;

        bool isOutOfRect = (pointX < rectTopX || rectBottomX < pointX) ||
                            (pointY < rectBottomY || rectTopY < pointY);

        bool bothConditions = (isOutOfRect && isWithinCircle);
        Console.WriteLine("Is within circle: " + isWithinCircle);
        Console.WriteLine("Is out of rectangle: " + isOutOfRect);
        Console.WriteLine("Both conditions: " + bothConditions);

    }
}