using System;
/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements 
 * that have maximal sum.
 */
class ElementsWithMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter N (elements in array): ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (elemtents with whom to make max sum):");
        int K = int.Parse(Console.ReadLine());
        if (K > N)
        {
            Console.WriteLine("N must be bigger than K!");
        }
        else
        {
            int[] array = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter {0} element: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = N - 1; i >= N - K; i--)
            {
                Console.Write(array[i] + " ");
                sum += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("The sum is : {0}", sum);
        }
    }
}