using System;
/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the 
 * index of each of its letters in the array.
 */
class ArrayOfLetters
{
    static void Main(string[] args)
    {
        char[] array = new char[26];
        int character = 65;
        for (int i = 0; i < 26; i++)
        {
            array[i] = (char)character;
            character++;
        }
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        int wordLenght = 0;
        while (word.Length > 0 && wordLenght < word.Length)
	    {
	        for (int j = 0; j < 26; j++)
            {
                if (word[wordLenght] == array[j])
                {
                    Console.Write(j + " ");
                }
            }
            wordLenght++;
	    }
        Console.WriteLine();
    }
}