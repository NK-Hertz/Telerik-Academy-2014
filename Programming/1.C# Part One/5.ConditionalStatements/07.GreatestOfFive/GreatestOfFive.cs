using System;

class GreatestOfFive
{
    //Write a program that finds the greatest of given 5 variables.
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int greatest = a;
        if (b > greatest)
        {
            greatest = b;
        }
        if (c > greatest)
        {
            greatest = c;
        }
        if (d > greatest)
        {
            greatest = d;
        }
        if (e > greatest)
        {
            greatest = e;
        }
        Console.WriteLine("The greatest is equal to {0}",greatest);

    }
}