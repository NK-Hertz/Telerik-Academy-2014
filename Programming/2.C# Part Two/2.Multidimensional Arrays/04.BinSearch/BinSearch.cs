using System;
/*
 * Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method 
 * Array.BinSearch() finds the largest number in the array which is ≤ K.
 */
class BinSearch
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int num;
        //Random rand = new Random();
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            //array[i] = rand.Next(0, 100);
        }
        Array.Sort(array);
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        if (array[0] > K)
        {
            Console.WriteLine("There is no element smaller or equal to K!");
        }
        else
        {
            int target = Array.BinarySearch(array, K);
            if (target >= 0)
            {
                num = array[target];
            }
            else
            {
                // pri target ravno na otricatelno chislo go obrushtame
                // v polojitelno - 1 i se poluchava tochniq index

                num = array[~target - 1];
            }
            Console.WriteLine("The number is: {0}", num);
        }

    }
}