using System;
/*Write a program that finds the index of given element in a sorted array of integers by using the binary search 
 * algorithm (find it in Wikipedia).
 */
class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter number elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Element {0}", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Console.WriteLine("Enter element to search for: ");
        int numToSearch = int.Parse(Console.ReadLine());
        int low = 0;
        int high = array.Length - 1;
        int mid;
        while (high >= low)
        {
            mid = (high + low) / 2;
            if (numToSearch < array[mid])
            {
                high = mid - 1;
            }
            else if (numToSearch > array[mid])
            {
                low = mid + 1;
            }
            else
            {
                Console.WriteLine("The index of {0} is {1}",numToSearch, mid );
                break;
            }
        }
    }
}