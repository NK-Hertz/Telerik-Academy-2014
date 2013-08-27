using System;
using System.IO;

/* Write a program that compares two text files line by line and prints the number of 
 * lines that are the same and the number of lines that are different. Assume the 
 * files have equal number of lines.
*/
class LineComparer
{
    static void Main()
    {
        using (StreamReader firstFile = new StreamReader(@"..\..\LineComparer.cs"))
        {
            using (StreamReader secFile = new StreamReader(@"..\..\LineComparer.cs"))
            {
                int numberOfLines = 0;
                int sameLines = 0;
                for (string firstLine, secLine; (firstLine = firstFile.ReadLine()) != null && (secLine = secFile.ReadLine()) != null; numberOfLines++)
                {
                    if (firstLine == secLine)
                    {
                        sameLines++;
                    }
                }
                Console.WriteLine("The number of lines is: {0}", numberOfLines);
                Console.WriteLine("The number of SAME lines is: {0}", sameLines);
            }
        }
    }
}