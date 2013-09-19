using System;
/*
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the 
 * same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
 */
class SequenceInStringMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int M = int.Parse(Console.ReadLine());
        string maxSequenceString = "";
        int maxSequenceInt = 1;
        string[,] matrix = new string[N, M];

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("Enter element [{0},{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        //on the same column
        for (int col = 0; col < M; col++)
        {
            int currentSequence = 1;
            string currentStringSequence = "";

            for (int row = 0; row < N - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence++;
                    currentStringSequence = matrix[row, col];
                    if (currentSequence > maxSequenceInt)
                    {
                        maxSequenceInt = currentSequence;
                        maxSequenceString = currentStringSequence;
                    }
                }
            }
        }

        if (maxSequenceInt > 1)
        {
            Console.WriteLine("{0} has been repeated {1} times on the same column"
                , maxSequenceString, maxSequenceInt);
            maxSequenceInt = 1;
            maxSequenceString = "";
        }
        else
        {
            Console.WriteLine("No sequence found on the same column");
        }

        //on the same row
        for (int row = 0; row < N; row++)
        {
            int currentSequence = 1;
            string currentStringSequence = "";
            for (int col = 0; col < M - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSequence++;
                    currentStringSequence = matrix[row, col];
                    if (currentSequence > maxSequenceInt)
                    {
                        maxSequenceInt = currentSequence;
                        maxSequenceString = currentStringSequence;
                    }
                }
            }
        }

        if (maxSequenceInt > 1)
        {
            Console.WriteLine("{0} has been repeated {1} times on the same row"
                , maxSequenceString, maxSequenceInt);
            maxSequenceInt = 1;
            maxSequenceString = "";
        }
        else
        {
            Console.WriteLine("No sequence found on the same row");
        }

        //diagonally doesnt work right with 
        //{1, qq, s}, {s, 1, qq}, {z, x, 1}
        for (int i = 0; i < M - 1; i++)
        {
            for (int row = 0; row < N - 1; row++)
            {
                int currentSequence = 1;
                string currentStringSequence = "";

                for (int col = i; col < M - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        currentStringSequence = matrix[row, col];
                        currentSequence++;
                        if (currentSequence > maxSequenceInt 
                            || currentStringSequence == maxSequenceString)
                        {
                            maxSequenceInt = currentSequence;
                            maxSequenceString = currentStringSequence;
                        }
                    }
                }
            }
        }

        if (maxSequenceInt > 1)
        {
            Console.WriteLine("{0} has been repeated {1} times diagonally"
                , maxSequenceString, maxSequenceInt);
            maxSequenceInt = 1;
            maxSequenceString = "";
        }
        else
        {
            Console.WriteLine("No sequence found diagonally");
        }

        //counter diagonally doesn`t work properly
        for (int row = N - 1; row > 0; row--)
        {
            int currentSequence = 1;
            string currentStringSequence = "";

            for (int col = M - 1; col > 0; col--)
            {
                if (matrix[row, col] == matrix[row - 1, col - 1])
                {
                    currentSequence++;
                    currentStringSequence = matrix[row, col];
                    if (currentSequence > maxSequenceInt
                        || currentStringSequence == maxSequenceString)
                    {
                        maxSequenceInt = currentSequence;
                        maxSequenceString = currentStringSequence;
                    }
                }
            }
        }
        if (maxSequenceInt > 1)
        {
            Console.WriteLine("{0} has been repeated {1} times reverse diagonally"
                , maxSequenceString, maxSequenceInt);
            maxSequenceInt = 1;
            maxSequenceString = "";
        }
        else
        {
            Console.WriteLine("No sequence found reverse diagonally");
        }

    }
}