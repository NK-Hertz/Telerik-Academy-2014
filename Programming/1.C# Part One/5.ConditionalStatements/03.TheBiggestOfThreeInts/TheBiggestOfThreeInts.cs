using System;

class TheBiggestOfThreeInts
{
    //Write a program that finds the biggest of three integers using nested
    //if statements.
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("A is the biggest and equals {0}",a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("B is the biggest and equals {0}", b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("C is the biggest and equals {0}", c);
        }
        //if they are equal
        else
            Console.WriteLine("None is greater");
    }
}