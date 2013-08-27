using System;
using System.Collections.Generic;
using System.IO;

/*Write a program that reads a text file containing a list of strings, sorts them and
 * saves them to another text file. Example: 
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
*/

class SortListOfStrings
{
    static void Main()
    {
        List<string> list = new List<string>();
        using (StreamWriter writer = new StreamWriter(@"..\..\SortedList.txt"))
        {
            using (StreamReader reader = new StreamReader(@"..\..\ListOfStrings.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }

                list.Sort();

                for (int i = 0; i < list.Count;i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }

        Console.WriteLine("List is sorted and ready for use!");
    }


}