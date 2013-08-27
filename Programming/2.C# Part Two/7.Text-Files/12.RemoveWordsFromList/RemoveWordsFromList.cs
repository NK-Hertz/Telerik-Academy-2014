using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

/* Write a program that removes from a text file all words listed in given another 
 * text file. Handle all possible exceptions in your methods.
 */
class RemoveWordsFromList
{
    static void Main()
    {
        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";

            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
                {
                    for (string line; (line = reader.ReadLine()) != null; )
                    {
                        writer.WriteLine(Regex.Replace(line, regex, ""));
                    }
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}