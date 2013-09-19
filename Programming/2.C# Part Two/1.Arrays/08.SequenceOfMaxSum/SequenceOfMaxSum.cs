using System;
/*Write a program that finds the sequence of maximal sum in given array. 
 * Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} > {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */
class SequenceOfMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter {0} element: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < elements; i++)
        {
            if (sum < 0)
            {
                sum = array[i];
            }
            else
            {
                sum += array[i];
            }
            if (sum >= maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine(maxSum);
    }
}