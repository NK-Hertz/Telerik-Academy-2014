using System;
using System.Threading;
using System.Globalization;

class PerimeterAndAreaOfCircle
{
    //Write a program that reads the radius r of a circle and prints its 
    //perimeter and area.

    static void Main()
    {
        //Standardization for the decimal mark
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        Console.WriteLine("Input radius (e.g.  1.41) :");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter of the circle is : " + perimeter);
        Console.WriteLine("The area of the circle is: " + area);

    }
}
