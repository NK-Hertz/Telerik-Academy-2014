using System;

class HexToBinary
{
    //Write a program to convert hexadecimal numbers to binary 
    //numbers (directly).
    static void Main()
    {
        Console.WriteLine("Enter number in hex(without the 0x part): ");
        string hex = Console.ReadLine();
        string binary = Convert.ToString(Convert.ToInt32(hex, 16),2).PadLeft(32, '0');
        Console.WriteLine(binary);
    }
}