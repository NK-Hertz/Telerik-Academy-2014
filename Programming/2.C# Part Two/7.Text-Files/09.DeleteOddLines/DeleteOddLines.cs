﻿using System;
using System.Collections.Generic;
using System.IO;

//Write a program that deletes from given text file all odd lines. The result should
//be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        int lineNum = 1;
        List<string> list = new List<string>();

        using (StreamReader reader = new StreamReader(@"..\..\DeleteOddLines.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                    
                if (lineNum % 2 == 0)
                {
                    list.Add(line);
                }
                lineNum++;
                line = reader.ReadLine();
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\DeleteOddLines.txt"))
        {
            for (int i = 0; i < list.Count; i++)
			{
                writer.WriteLine(list[i]); 
			}
        }
    }
}