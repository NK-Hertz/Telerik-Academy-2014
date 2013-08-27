using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class PrintOddLines
{
    static void Main()
    {
        
        StreamReader reader = new StreamReader(@"..\..\PrintOddLines.cs");
        using (reader)
        {
            int lineNumb = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                
                if (lineNumb % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                lineNumb++;
                line = reader.ReadLine();
            }
        }
    }
}