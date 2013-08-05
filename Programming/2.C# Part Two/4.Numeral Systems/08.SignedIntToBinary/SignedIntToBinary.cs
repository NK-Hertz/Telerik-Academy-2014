using System;

class SignedIntToBinary
{
    //Write a program that shows the binary representation of given 
    //16-bit signed integer number (the C# type short).
    static void Main()
    {
        Console.WriteLine("Enter number from -32,768 to 32,767:: ");
        short num = short.Parse(Console.ReadLine());
        string inBinary = Convert.ToString(num, 2).PadLeft(16, '0');
        Console.WriteLine(inBinary);
    }
}