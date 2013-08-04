using System;

class GCD
{
    //Write a program that calculates the greatest common divisor (GCD) of given
    //two numbers. Use the Euclidean algorithm (find it in Internet).

    static void Main()
    {
        Console.Write("Enter first number=");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number=");
        int second = int.Parse(Console.ReadLine());
        int gcd = 1;
        int bucket = 0;
        //change of values, so the value of first is bigger
        if (second > first)
        {
            bucket = second;
            second = first;
            first = bucket;
        }
        //loop which finds the gratest common devider
        //the gcd equals the reminder left from deviding first with second
        //and switch values so the deviding can continue until we can`t devide anymore
         do
        {
            gcd = first % second;
            first = second;
            second = gcd;
        }
        while (gcd > 0);
        Console.WriteLine("The GCD is {0}", first);
    }
}