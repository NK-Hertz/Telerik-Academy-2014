using System;

class SwitchingValues
{
    //Declare  two integer variables and assign them with 5 and 10 and after 
    //that exchange their values.
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
        int container = firstValue;
        firstValue = secondValue;
        secondValue = container;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
    }
}
