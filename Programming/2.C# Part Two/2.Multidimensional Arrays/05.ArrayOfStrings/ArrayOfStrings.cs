using System;
/*
 * You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing 
 * them).
 */
class ArrayOfStrings
{
    //defined here so it can be used in the methods and in Main()
    static int elements;

    static void CompareStringsNow(string[] myArray)
    {
        int[] byLength = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            byLength[i] = myArray[i].Length;
        }
        Array.Sort(byLength, myArray);
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        elements = int.Parse(Console.ReadLine());

        string[] myArray = new string[elements];
        //input array
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter {0} element: ",i);
            myArray[i] = Console.ReadLine();
        }
        Console.WriteLine();
        //calling method
        CompareStringsNow(myArray);
        Console.WriteLine("The new order is: ");
        //print ordered array
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}