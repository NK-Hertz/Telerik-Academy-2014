using System;
using System.IO;
using System.Text.RegularExpressions;

/*Write a program that deletes from a text file all words that start with the prefix 
 * "test". Words contain only the symbols 0...9, a...z, A…Z, _.
*/
class DeleteWords
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                for (string line; (line = reader.ReadLine()) != null; )
                {
                    writer.WriteLine(Regex.Replace(line, @"\btest\w*", ""));
                }
            }
        }
    }
}