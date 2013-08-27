using System;
using System.IO;
using System.Text.RegularExpressions;

/* Modify the solution of the previous problem to replace only whole words (not 
 * substrings).
*/

class ReplaceWords
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                for (string line; (line = reader.ReadLine()) != null; )
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart", "finish"));
                }
            }
        }
    }
}