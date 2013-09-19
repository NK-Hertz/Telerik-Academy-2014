using System;
//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first word:");
        string firstWord = Console.ReadLine();
        Console.WriteLine("Enter second word: ");
        string secWord = Console.ReadLine();

        char[] firstArr;
        firstArr = firstWord.ToCharArray();
        char[] secArr;
        secArr = secWord.ToCharArray();
        int bestLenght = 0;

        if (firstWord.Length > secWord.Length)
        {
            bestLenght = firstWord.Length;
        }
        else
        {
            bestLenght = secWord.Length;
        }

        bool isEqual = true;
        for (int i = 0; i < bestLenght; i++)
        {
            if (firstArr[i] != secArr[i])
            {
                isEqual = false;
            }
        }
        Console.WriteLine("Are first and second words equal: {0}", isEqual);
    }
}
        