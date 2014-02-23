using System;
using System.Text;
/*
 * Implement an extension method Substring(int index, int length) for the class StringBuilder that 
 * returns new StringBuilder and has the same functionality as Substring in the class String.
 */
class ExtensionMethodSubstring
{
    static void Main()
    {
        StringBuilder newSubstringTest = new StringBuilder();
        newSubstringTest.AppendLine("This LINE HERE to be retrived!");

        string result = newSubstringTest.SUBString(21).ToString();
        Console.WriteLine(result);

        result = newSubstringTest.SUBString(5, 9).ToString();
        Console.WriteLine(result);
    }
}