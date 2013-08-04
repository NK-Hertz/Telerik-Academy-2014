using System;

class Print1toN
{
    //Write a program that prints all the numbers from 1 to N.
    static void Main()
    {
        Console.Write("n= ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}