using System;

class DecimalToHex
{
    //Write a program to convert decimal numbers to their hexadecimal representation.
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        string hex = Convert.ToString(num, 16).ToUpper();
        Console.WriteLine(hex);
    }
}