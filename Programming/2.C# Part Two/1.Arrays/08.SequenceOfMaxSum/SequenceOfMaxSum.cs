using System;

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