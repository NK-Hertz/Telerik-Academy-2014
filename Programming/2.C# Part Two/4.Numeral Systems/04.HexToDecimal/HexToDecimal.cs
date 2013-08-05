using System;

class HexToDecimal
{
    //Write a program to convert hexadecimal numbers to their decimal representation.
    static void Main()
    {
        Console.WriteLine("Enter number in hex (without the 0x part): ");
        string hex = Console.ReadLine();
        int num = Convert.ToInt32(hex, 16);
        Console.WriteLine(num);
    }
}