using System;
/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
 * move it at the second position, etc.
 */
class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter how much elements you want: ");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int smallest;
        for (int i = 0; i < elements - 1; i++)
        {
            smallest = i;
            for (int j = i + 1; j < elements; j++)
            {
                if (array[smallest] > array[j])
                {
                    smallest = j;
                }
            }
            int bucket = array[smallest];
            array[smallest] = array[i];
            array[i] = bucket;
        }

        for (int i = 0; i < elements; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}