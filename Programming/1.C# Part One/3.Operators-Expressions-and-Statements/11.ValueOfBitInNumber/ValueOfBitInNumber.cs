using System;

class ValueOfBitInNumber
{
    //Write an expression that extracts from a given integer i the value of a 
    //given bit number b. Example: i=5; b=2  value=1.

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2));
        int mask = 1 << b;
        int vAndMask = num & mask;
        int bit = vAndMask >> b;
        int value;
        if (bit == 1)
            value = 1;
        else
            value = 0;
        Console.WriteLine(value);          
    }
}