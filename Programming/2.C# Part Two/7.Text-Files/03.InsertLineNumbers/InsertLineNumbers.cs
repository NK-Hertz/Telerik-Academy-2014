using System;
using System.IO;

/* Write a program that reads a text file and inserts line numbers in front of each of 
 * its lines. The result should be written to another text file.
*/
class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            int lineNum = 1;
            using (StreamReader reader = new StreamReader(@"..\..\InsertLineNumbers.cs"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.Write("LineNumber [{0}] ", lineNum);
                    writer.WriteLine(line);
                    lineNum++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}