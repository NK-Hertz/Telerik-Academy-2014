using System;
//Write a program that reads two arrays from the console and compares them element by element.
class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter how many elements you want in the array: ");
        int elements = int.Parse(Console.ReadLine());
        int[] firstArr = new int[elements];
        int[] secArr = new int[elements];
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.WriteLine("Enter value for {0} element in the first array: ", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secArr.Length; i++)
        {
            Console.WriteLine("Enter value for {0} element in the second array: ", i);
            secArr[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;
        for (int i = 0; i < elements; i++)
        {
            if (firstArr[i] != secArr[i])
            {
                isEqual = false;
            }
        }
        Console.WriteLine("Are first and second arrays equal: {0}", isEqual);
    }
}