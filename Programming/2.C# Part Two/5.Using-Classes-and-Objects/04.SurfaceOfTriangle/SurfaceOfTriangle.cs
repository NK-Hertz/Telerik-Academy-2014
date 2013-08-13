using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them.
//Use System.Math.

class SurfaceOfTriangle
{
    static void SideAndAltitude(double b, double h)
    {
        double result = (b * h) / 2;
        Console.WriteLine(result);
    }

    static void ThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine(result);
    }

    static void TwoSideAndAngle(double a, double b, double angle)
    {
        double result = (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
        Console.WriteLine(result);
    }

    static void Main()
    {
        Console.WriteLine("Choose how to calculate the surface of the triangle: ");
        Console.WriteLine("1 - by side and altitude to it.");
        Console.WriteLine("2 - by three sides.");
        Console.WriteLine("3 - by two sides and an angle between them");
        char options = char.Parse(Console.ReadLine());
        switch (options)
        { 
            case '1':
                Console.WriteLine("Enter b: ");
                double @base = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter h: ");
                double height = double.Parse(Console.ReadLine());
                SideAndAltitude(@base, height);
                break;
            case '2':
                Console.WriteLine("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                double c = double.Parse(Console.ReadLine());
                ThreeSides(a, b, c);
                break;
            case '3':
                Console.WriteLine("Enter a: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle: ");
                double angle = double.Parse(Console.ReadLine());
                TwoSideAndAngle(sideA, sideB, angle);
                break;
            default:
                Console.WriteLine("Please select from the given options!");
                break;
        }
    }
}