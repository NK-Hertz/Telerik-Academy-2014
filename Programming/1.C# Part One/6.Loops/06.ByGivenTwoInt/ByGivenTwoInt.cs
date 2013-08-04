using System;

class ByGivenTwoInt
{
    //Write a program that, for a given two integer numbers N and X, calculates 
    //the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X=");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double fact = 1;
        for (double i = 1; i <= n; i++)
        {
            fact *= i;
            sum += fact / Math.Pow(x, i);
        }
        Console.WriteLine("S={0}",sum);
    }
}