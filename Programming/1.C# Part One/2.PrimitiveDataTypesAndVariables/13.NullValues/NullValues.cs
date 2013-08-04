using System;

class NullValues
{
    //Create a program that assigns null values to an integer and to double 
    //variables. Try to print them on the console, try to add some values or the
    //null literal to them and see the result.
    static void Main()
    {
        int? nullInt = null;
        double? doubleInt = null;
        Console.WriteLine(nullInt);
        Console.WriteLine(doubleInt);
        nullInt = 5;
        doubleInt = 12.312414;
        Console.WriteLine(nullInt);
        Console.WriteLine(doubleInt);
        nullInt = null;
    }
}
