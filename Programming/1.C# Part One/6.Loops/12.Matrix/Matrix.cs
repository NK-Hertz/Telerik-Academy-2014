using System;

class Matrix
{
    //Write a program that reads from the console a positive integer number N 
    //(N < 20) and outputs a matrix like the following:
    static void Main()
    {
        Console.Write("Enter number:");
        int num = int.Parse(Console.ReadLine());
        int[] arr = new int[num];
        int bucket = 1;
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write(bucket + i + j + " ");
            }
            Console.WriteLine();
        }
    
    }
}