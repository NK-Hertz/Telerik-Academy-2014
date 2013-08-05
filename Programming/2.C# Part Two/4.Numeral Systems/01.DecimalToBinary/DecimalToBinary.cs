using System;

class DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        string numInBinary = Convert.ToString(num, 2).PadLeft(32, '0');
        Console.WriteLine(numInBinary);
    }
}