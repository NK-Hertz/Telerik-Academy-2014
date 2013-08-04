using System;

class QuadraticEquation
{
    //Write a program that enters the coefficients a, b and c of a quadratic 
    //equation a*x2 + b*x + c = 0
	//and calculates and prints its real roots. Note that quadratic equations 
    //may have 0, 1 or 2 real roots.
    static void Main()
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c= ");
        int c = int.Parse(Console.ReadLine());

        int discriminant = b * b - 4 * a * c;
        double container = 0;
        double secContainer = 0;
        if (discriminant > 0)   //if discriminant is greater than 0
        {
            container = -b + Math.Sqrt(discriminant) / 2.0 * a;
            secContainer = -b - Math.Sqrt(discriminant) / 2.0 * a;
            Console.WriteLine("The first root is equal to: {0}", container);
            Console.WriteLine("The second root is equal to: {0}", secContainer);
        }
        else if (discriminant == 0) //if discriminant equals 0
        {
            container = -b / 2.0 * a;
            Console.WriteLine("The root is equal to: {0}", container);
        }
        else //if discriminant is negative
        {
            Console.WriteLine("The discriminant is negative");
        }
    }
}