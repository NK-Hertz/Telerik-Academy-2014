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
        string sequence = "";

        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < elements - 1; i++)
        {
            
            if (sum < 0)
            {
                sum = array[i];
                sequence = array[i].ToString();
            }
            else
            {
                sum += array[i];
                if (array[i] + array[i+1] != 0)
                {
                    sequence += array[i];
                    sequence += " ";
                }
            }

            if (sum >= maxSum)
            {
                maxSum = sum;
            }
        }

        Console.WriteLine("The maximum sum is: {0}", maxSum);
        Console.WriteLine("and the sequence is: {0}", sequence);
    }
}