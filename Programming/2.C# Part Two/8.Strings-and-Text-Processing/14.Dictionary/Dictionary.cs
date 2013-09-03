/* A dictionary is stored as a sequence of text lines containing words and their 
 * explanations. Write a program that enters a word and translates it by using the
 * dictionary. Sample dictionary:
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes
*/
using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"};
        string word = ".NET";

        foreach (string item in dictionary)
        {
            var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;
            if (fragments[1].Value == word)
            {
                Console.WriteLine(fragments[2]);
            }
        }
    }
}