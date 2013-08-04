using System;
using System.Numerics;

class CalculateFactEquation
{
    //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        if (k <= 0 || n <= 0)
        {
            Console.WriteLine("Error! The numbers have to be bigger than 0!");
        }
        else if (n >= k)
        {
            Console.WriteLine("Error! N has to be smaller than K!");
        }
        else
        {

            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger factKN = 1;
            for (int i = 1; i <= k; i++)
            {
                if (i <= n)
                {
                    factN *= i;

                }
                if (i <= (k - n))
                {
                    factKN *= i;
                }
                factK *= i;
            }
            Console.WriteLine("N!={0}", factN);
            Console.WriteLine("K!={0}", factK);
            Console.WriteLine("(K-N)!={0}", factKN);
            BigInteger result = factN * factK / factKN;
            Console.WriteLine("And the result is {0}",result);
        }
    }
}
