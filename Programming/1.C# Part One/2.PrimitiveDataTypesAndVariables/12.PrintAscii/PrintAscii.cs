using System;

class PrintAscii
{
    //Find online more information about ASCII (American Standard Code for 
    //Information Interchange) and write a program that prints the entire ASCII
    //table of characters on the console.

    static void Main()
    {
        for (int i = 0; i < 128; i++)
        {
            Console.Write(i);
            Console.WriteLine(" The symbol: " + (char)i);
        }
    }
}