using System;
using System.IO;

/*Write a program that extracts from given XML file all the text without the tags. 
 * Example:
 * <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
 * <interest> Games</instrest><interest>C#</instrest><interest> Java</instrest>
 * </interests></student>

*/
class ExtractFromXML
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\this.xml"))
        {
            //reads text
            for (int i; (i = reader.Read()) != -1; )
            {
                //between > and <
                if (i == '>') 
                {
                    string text = String.Empty;

                    while ((i = reader.Read()) != -1 && i != '<')
                    {
                        text += (char)i;
                    }
                    if (!String.IsNullOrWhiteSpace(text))
                    {
                        //removes all leading and trailing white-space characters
                        Console.WriteLine(text.Trim());
                    }
                }
            }
        }
    }
}