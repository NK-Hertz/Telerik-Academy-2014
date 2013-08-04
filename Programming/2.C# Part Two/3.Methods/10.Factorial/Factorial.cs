using System;
using System.Numerics;

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