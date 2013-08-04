using System;
using System.Numerics;

class SumNFibonacciMembers
{
    //Write a program that reads a number N and calculates the sum of the first 
    //N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 
    //55, 89, 144, 233, 377, …
    //Each member of the Fibonacci sequence (except the first two) is a sum of 
    //the previous two members.

    static void Main()
    {
        Console.Write("Enter N=");
        long num = long.Parse(Console.ReadLine());
        // big integer for big numbers
        BigInteger[] N = new BigInteger[num];
        BigInteger sum = 0;
        for (int i = 0; i < num; i++)
        {
            //if i equals 0, the first value of N equals 0
            if (i == 0)
            {
                N[i] = 0;
            }
            //if i equals 1, the second value of N equals 1
            else if (i == 1)
            {
                N[i] = 1;
            }
            //if i equals any other number it follows this equation
            else
            {
                //the value is formed by the two previous values
                //N2=N1+N0    N3=N2+N1 and so on
                N[i] = N[i - 1] + N[i - 2];
            }
            sum = sum + N[i];
            //output each value of the array
            Console.Write(" {0}",N[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the first {0} members is = {1}",num,sum);
    }
}