using System;

class factorialNOverK
{
    //Write a program that calculates N!/K! for given N and K (1<K<N).
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:");
        int k = int.Parse(Console.ReadLine());
        if (k <= 0 || n <= 0)
        {
            Console.WriteLine("Error! The numbers have to be bigger than 0!");
        }
        else if (k >= n)
        {
            Console.WriteLine("Error! K has to be smaller than N!");
        } 
        else
        {
            int factN = 1;
            for (int i = k + 1; i <= n; i++)
            {
                factN *= i;
            }
            Console.WriteLine(factN);
        }
    }
}