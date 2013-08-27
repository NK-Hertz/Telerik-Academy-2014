using System;
using System.IO;

/* Write a program that replaces all occurrences of the substring "start" with the 
 * substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
*/

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                for (string line; (line = reader.ReadLine()) != null;)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                }
            }
        }
    }
}