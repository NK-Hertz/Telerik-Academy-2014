using System;

class MostFrequentNum
{
    static void Main()
    {
        Console.WriteLine("Enter how much elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter {0} element", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int freqNum = 0;
        int mostFreqNum = 0;
        int count = 1;
        int maxCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    freqNum = array[i];
                    count++;
                }
            }
            if (count > maxCount)
            {
                mostFreqNum = freqNum;
                maxCount = count;
            }
            count = 1;
        }
        Console.WriteLine("The most common number is {0} and its found {1} times", mostFreqNum, maxCount);
    }
}