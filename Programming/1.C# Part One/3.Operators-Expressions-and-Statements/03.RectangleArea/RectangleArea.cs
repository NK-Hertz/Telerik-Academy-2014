using System;

class RectangleArea
{
    //Write an expression that calculates rectangle’s area by given width and 
    //height.
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double rectangleArea = width * height;
        Console.WriteLine(rectangleArea);
    }
}