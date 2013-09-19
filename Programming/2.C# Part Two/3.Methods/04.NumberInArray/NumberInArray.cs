using System;
/*
 * Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working 
 * correctly.
 */
class NumberInArray
{
    static void CounterTheNum(int[] array,int num)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                count++;
            }
        }
        Console.WriteLine("{0} times",count);

    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] bucketArray = new int[elements];

        for (int i = 0; i < elements; i++)
        {
            bucketArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter number you want to search for: ");
        int searchNum = int.Parse(Console.ReadLine());

        CounterTheNum(bucketArray,searchNum);

    }
}