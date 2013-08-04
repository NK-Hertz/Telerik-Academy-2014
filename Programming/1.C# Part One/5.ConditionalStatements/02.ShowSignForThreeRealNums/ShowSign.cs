using System;

class ShowSign
{
    //Write a program that shows the sign (+ or -) of the product of three real 
    //numbers without calculating it. Use a sequence of if statements.

    static void Main()
    {
        sbyte count = 0;
        int a = int.Parse(Console.ReadLine());
        if (a < 0)
        {
            count++;
        }
        int b = int.Parse(Console.ReadLine());
        if (b < 0)
        {
            count++;
        }
        int c = int.Parse(Console.ReadLine());
        if(c < 0)
        {
            count++;
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The sign will be 0");
        }
        // if its different than 0
        else if (count % 2 != 0)
        {
            Console.WriteLine("The sign is '-'");
        }
        else
        {
            Console.WriteLine("The sign is '+'");
        }
    }
}