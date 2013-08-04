using System;
using System.Numerics;

class CatalanNumbers
{
    //Write a program to calculate the Nth Catalan number by given N.
    static void Main()
    {
        Console.Write("Enter n=");
        double n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Error!N has to be bigger than 0!");
        }
        else
        {
            BigInteger nFact = 1;
            BigInteger plusOneFact = 1;
            BigInteger doubleFact = 1;
            BigInteger result = 1;
            for (ulong i = 1; i <= 2 * n; i++)
            {
                //my (2n)!
                doubleFact = doubleFact * i;
                if (i <= n + 1)
                {
                    //(n+1)!
                    plusOneFact = plusOneFact * i;
                }
                if (i <= n)
                {
                    //n!
                    nFact = nFact * i;
                }
                // (2n)!/(n+1)!*n!
                result = (BigInteger)doubleFact / (plusOneFact * nFact);
            }
            Console.WriteLine("The result is {0,0:0}", result);
        }
    }
}