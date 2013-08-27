using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

class NewTxtFile
{
    static void Main()
    {
        string newTxtFile = @"..\..\NewTxtFile.cs";
        string appConfig = @"..\..\App.config";
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (writer)
        {
            using (StreamReader reader = new StreamReader(newTxtFile))
            {
                string line = reader.ReadToEnd();
                writer.WriteLine(line);
            }

            using (StreamReader reader = new StreamReader(appConfig))
            {
                string line = reader.ReadToEnd();
                writer.WriteLine(line);
            }

            Console.WriteLine("Concatenation Ready!");
        }
    }
}