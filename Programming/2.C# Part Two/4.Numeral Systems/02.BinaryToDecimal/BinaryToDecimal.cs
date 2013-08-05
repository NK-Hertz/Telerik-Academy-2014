using System;

class BinaryToDecimal
{
    //Write a program to convert binary numbers to their decimal representation.
    static void Main()
    {
        Console.WriteLine("Enter a number in binary: ");
        string numInBinary = Console.ReadLine();
        int num = Convert.ToInt32(numInBinary, 2);
        Console.WriteLine(num);
    }
}