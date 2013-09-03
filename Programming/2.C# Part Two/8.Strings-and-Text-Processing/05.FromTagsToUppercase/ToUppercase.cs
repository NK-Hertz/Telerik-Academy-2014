/* You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be 
 * nested. Example:
 * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>
 * anything</upcase> else.
 * 	The expected result:
 * 	We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/
using System;

class ToUppercase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            

            if (text.Substring(i, 8) == "<upcase>")
            {
                startIndex = i + 8;
                i = startIndex;
            }

            if (text.Substring(i, 9) == "</upcase>")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                string betweenTags = text.Substring(startIndex, length);
                text = text.Replace(betweenTags, betweenTags.ToUpper());
                text = text.Remove(startIndex - 8, 8).Remove(endIndex - 8, 9);                
            }
        }
        Console.WriteLine(text);
    }
}