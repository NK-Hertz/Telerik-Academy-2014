using System;

class PrintGreaterNum
{
    //Write a program that gets two numbers from the console and prints the 
    //greater of them. Don’t use if statements.

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        // If a>b theGreater equals a, else it equals b
        int theGreater = (a > b) ? a : b;
        // If a>b chGreater equals the char 'a', else it equals the char 'b'
        char chGreater = (a > b) ? 'a' : 'b';   
        Console.WriteLine("The greater is {0} = {1}",chGreater,theGreater);
    }
}