/*Write a program that reads a list of words, separated by spaces and prints the 
 * list in an alphabetical order.
*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PrintInAlphabeticalOrder
{
    static void Main()
    {
        string str = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
        List<string> words = new List<string>();

        foreach (Match word in Regex.Matches(str, @"\w+"))
        {
            words.Add(word.Value);
        }

        words.Sort();

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}