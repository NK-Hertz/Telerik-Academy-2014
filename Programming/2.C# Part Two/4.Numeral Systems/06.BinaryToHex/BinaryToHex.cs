using System;

class BinaryToHex
{
    //Write a program to convert binary numbers to hexadecimal
    //numbers (directly).
    static void Main()
    {
        Console.WriteLine("Enter number in binary: ");
        string binary = Console.ReadLine();
        string hex = Convert.ToString(Convert.ToInt32(binary, 2), 16).ToUpper();
        Console.WriteLine(hex);
    }
}