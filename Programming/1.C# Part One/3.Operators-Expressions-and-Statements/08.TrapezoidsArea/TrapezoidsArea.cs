using System;

class TrapezoidsArea
{
    //Write an expression that calculates trapezoid's area by given sides a and 
    //b and height h.

    static void Main()
    {
        Console.WriteLine("Vuvedete strana a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete strana b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete visochina h: ");
        double h = double.Parse(Console.ReadLine());
        double trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("Liceto na trapeca e : " + trapezoidArea);
    }
}