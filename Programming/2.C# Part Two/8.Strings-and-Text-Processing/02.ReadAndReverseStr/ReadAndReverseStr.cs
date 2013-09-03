//Write a program that reads a string, reverses it and prints the result at the 
//console.
//Example: "sample"  "elpmas".

using System;

class ReadAndReverseStr
{
    static void Main()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(arr);
    }
}