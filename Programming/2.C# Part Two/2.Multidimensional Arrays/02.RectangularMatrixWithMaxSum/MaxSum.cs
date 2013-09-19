using System;
/*
 * Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M];
        int maxSum = 0;
        // for random numbers
        Random rand = new Random();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = rand.Next(1, 101);
            }
        }
        //razmer na matricata
        int platformMaxX = 3;
        int platformMaxY = 3;
        //matrix.GetLength(0) - 2 zashtoto ne mojem da vzemem nqkoe chislo
        //ot taz red ili colona i da se poluchi platforma 3x3
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = 0;

                for (int platformX = row; platformX < platformMaxX + row; platformX++)
                {
                    for (int platformY = col; platformY < platformMaxY + col ; platformY++)
                    {
                        currentSum += matrix[platformX, platformY];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine("The max sum equals: {0}",maxSum);
    }
}