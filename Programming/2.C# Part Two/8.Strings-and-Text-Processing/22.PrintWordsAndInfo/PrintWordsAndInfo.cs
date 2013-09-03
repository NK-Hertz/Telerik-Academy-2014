/*Write a program that reads a string from the console and lists all different words
 * in the string along with information how many times each word is found.
 */
using System;
using System.Collections.Generic;

class PrintWordsAndInfo
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
        string[] allWordsArr = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var word in allWordsArr)
        {
            if (dict.ContainsKey(word))
            {
                dict[word] = dict[word] + 1;
            }
            else
            {
                dict.Add(word, 1);
            }
        }

        foreach (var word in dict)
        {
            Console.WriteLine("{0,-10} - {1}", word.Key, word.Value);
        }
    }
}