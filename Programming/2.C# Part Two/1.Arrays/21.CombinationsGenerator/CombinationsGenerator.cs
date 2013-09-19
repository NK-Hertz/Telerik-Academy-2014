using System;
/*
 * Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
 * Example:	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 */
class CombinationsGenerator
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[k];
        Variations(array, 0, n, 1);
    }

    static void Variations(int[] array, int index, int n, int k)
    {
        if (index == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = k; j <= n; j++)
            {
                array[index] = j;
                Variations(array, index + 1, n, j + 1);
            }
        }
    }
}