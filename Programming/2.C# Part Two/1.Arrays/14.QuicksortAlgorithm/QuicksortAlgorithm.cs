using System;
/*
 * Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
 */
class QuicksortAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int elements = int.Parse(Console.ReadLine());
        string[] array = new string[elements];
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter string{0}:", i);
            array[i] = Console.ReadLine();
        }
        Quicksort(array, 0, array.Length - 1);
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static void Quicksort(string[] bucketArr, int left, int right)
    {
        int i = left;
        int j = right;
        string pivot = bucketArr[(left + right) / 2];
 
        while (i <= j)
        {
            while (bucketArr[i].CompareTo(pivot) < 0)
            {
                i++;
            }
 
            while (bucketArr[j].CompareTo(pivot) > 0)
            {
                j--;
            }
 
            if (i <= j)
            {
                string bucket = bucketArr[i];
                bucketArr[i] = bucketArr[j];
                bucketArr[j] = bucket;
 
                i++;
                j--;
            }
        }
        if (left < j)
        {
            Quicksort(bucketArr, left, j);
        }
 
        if (i < right)
        {
            Quicksort(bucketArr, i, right);
        }
    }
 
}