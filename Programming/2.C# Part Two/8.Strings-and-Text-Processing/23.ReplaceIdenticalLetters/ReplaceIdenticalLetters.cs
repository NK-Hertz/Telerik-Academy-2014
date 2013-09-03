/*Write a program that reads a string from the console and replaces all series of 
 * consecutive identical letters with a single one. Example: 
 * "aaaaabbbbbcdddeeeedssaa" = "abcdedsa".
*/
using System;
using System.Text.RegularExpressions;

class ReplaceIdenticalLetters
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa";

        Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
    }
}