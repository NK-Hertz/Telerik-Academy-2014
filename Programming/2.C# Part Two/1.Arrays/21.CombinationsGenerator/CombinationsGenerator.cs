using System;

class CombinationsGenerator
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int K = int.Parse(Console.ReadLine());

        int[] array = new int[K];
        Variations(array, 0, N, 1);
    }

    static void Variations(int[] array, int index, int N, int K)
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
            for (int j = K; j <= N; j++)
            {
                array[index] = j;
                Variations(array, index + 1, N, j + 1);
            }
        }
    }
}