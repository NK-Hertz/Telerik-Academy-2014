using System;

class FindSequenceBySum
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        int sum = 0;
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter S = ");
        int S = int.Parse(Console.ReadLine());
        for (int i = 0; i < elements; i++)
        {
            sum = array[i];
            for (int j = i + 1; j < elements; j++)
            {
                sum += array[j];
                if (sum == S)
                {
                    Console.WriteLine("There is a sequence equal to S!");
                }
            }
            sum = 0;
        }
    }
}