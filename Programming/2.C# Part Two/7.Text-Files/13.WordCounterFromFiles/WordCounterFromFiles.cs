using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

/*Write a program that reads a list of words from a file words.txt and finds how many 
 * times each of the words is contained in another file test.txt. The result should be
 * written in the file result.txt and the words should be sorted by the number of 
 * their occurrences in descending order. Handle all possible exceptions in your 
 * methods.
 */
class WordCounterFromFiles
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            int[] count = new int[words.Length];

            using (StreamReader reader = new StreamReader("../../text.txt"))
            {
                for (string line; (line = reader.ReadLine()) != null; )
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        count[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                    }
                }
            }

            Array.Sort(count, words);

            using (StreamWriter writer = new StreamWriter("../../result.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0} : {1} times", words[i], count[i]);
                }
            }
            Console.WriteLine("Finished succesfully!");
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
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}