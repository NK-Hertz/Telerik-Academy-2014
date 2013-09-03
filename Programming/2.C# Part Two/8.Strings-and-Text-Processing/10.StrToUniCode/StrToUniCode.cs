/*Write a program that converts a string to a sequence of C# Unicode character 
 * literals. Use format strings. Sample input:
*/
using System;
using System.Text;

class StrToUniCode
{
    static void Main()
    {
        string text = "Hi!";
        StringBuilder uniCode = new StringBuilder(text.Length * 6);

        for (int i = 0; i < text.Length; i++)
        {
            uniCode.AppendFormat("\\u{0:X4}", (int)text[i]);
        }

        Console.WriteLine(uniCode);
    }

}