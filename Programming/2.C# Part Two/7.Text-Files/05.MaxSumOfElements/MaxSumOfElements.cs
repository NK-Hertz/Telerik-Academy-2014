using System;
using System.IO;
/* Write a program that reads a text file containing a square matrix of numbers and 
 * finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The 
 * first line in the input file contains the size of matrix N. Each of the next N lines
 * contain N numbers separated by space. The output should be a single number in a 
 * separate text file. Example:
 * 4
 * 2 3 3 4
 * 0 2 3 4	  ->	17
 * 3 7 1 2
 * 4 3 3 2
*/
class MaxSumOfElements
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"matrix.txt"))
        {
            int N = int.Parse(reader.ReadLine());
            int[,] arr = new int[N,N];
            //from text to arr element
            for (int i = 0; i < N; i++)
            {
                string[] line = reader.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = int.Parse(line[j]);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            int maxSum = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    int sum = arr[i, j] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                } 
            }
            Console.WriteLine("The max sum in the matrix is: {0}", maxSum);
        }
    }
}