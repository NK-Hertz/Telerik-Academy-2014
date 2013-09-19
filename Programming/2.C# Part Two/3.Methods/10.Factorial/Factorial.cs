using System;
using System.Numerics;
/*
 * Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented 
 * as array of digits by given integer number. 

 */
class Factorial
{
    static BigInteger FactorialThis(int num)
    {
        BigInteger fact = 1;
        for (int i = num; i > 0; i--)
        {
            fact *= i;
        }
        return fact;
    }

    static void Main()
    {
        BigInteger[] myArray = new BigInteger[100];
        for (int i = 0; i < 100; i++)
        {
            myArray[i] = i + 1;
        }

        for (int i = 0; i < 100; i++)
        {
            myArray[i] = FactorialThis(i + 1);
        }

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("element {0} = {1}",i + 1, myArray[i]);
        }
        Console.WriteLine();
        
    }
}