/*Write a program for extracting all email addresses from given text. All substrings
 * that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string str = "Static void Main() nakov@telerik.com. using System,nakov@gmail.com return";

        foreach (var item in Regex.Matches(str, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}