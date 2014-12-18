using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int numberOfWords = int.Parse(Console.ReadLine());
        //List<string> magicWords = new List<string>();

        //for (int i = 0; i < numberOfWords; i++)
        //{
        //    magicWords.Add(Console.ReadLine());
        //}

        int wordLenght = 0;
        int postion = 0;
        int index = 0;
        string item = "";

        string[] magicWords = new string[numberOfWords];
        string[] newMagicWords = new string[numberOfWords];
        for (int i = 0; i < numberOfWords; i++)
        {
            magicWords[i] = Console.ReadLine();
        }

        for (int i = 0; i < numberOfWords; i++)
        {
            wordLenght = magicWords[index].Length;
            postion = wordLenght % (numberOfWords + 1);
            if (postion >= numberOfWords)
            {
                postion = postion % numberOfWords;
                postion++;
            }

            if (newMagicWords[postion] != null)
            {
                newMagicWords[index] = newMagicWords[postion];
            }

            newMagicWords[postion] = magicWords[index];

            

            index++;
        }

        //reorder
        //for (int i = 0; i < numberOfWords - 1; i++)
        //{
        //    wordLenght = magicWords[index].Length;
        //    postion = wordLenght % (numberOfWords + 1);
        //    item = magicWords[index];
        //    if (postion >= numberOfWords)
        //    {
        //        postion = postion % numberOfWords;
        //        postion++;
        //    }
        //    else if (postion <= 0)
        //    {
        //        postion = 1;
        //    }
        //    magicWords.RemoveAt(index);
        //    magicWords.Insert(postion-1, item);
        //    index = postion - 1;
        //    index++;
        //}

        //print
        StringBuilder str = new StringBuilder();
        string bucket;
        index = 0;
        int charIndex = 0;
        int bestCharCount = 0;

        while (true)
        {
            bucket = newMagicWords[index];
            int charCount = newMagicWords[index].Length;

            if (charCount > bestCharCount)
            {
                bestCharCount = charCount;
            }

            if (charIndex == bestCharCount)
            {
                break;
            }

            if (index == numberOfWords)
            {
                index = 0;
                charIndex++;
            }

            if (charIndex >= newMagicWords[index].Length)
            {
                index++;
                if (index == numberOfWords)
                {
                    index = 0;
                    charIndex++;
                }
                continue;
            } 
            
            
            str.Append(bucket[charIndex]);
            index++;

            if (index == numberOfWords)
            {
                index = 0;
                charIndex++;
            }

            if (charIndex > newMagicWords[index].Length)
            {
                continue;
            }
        }

        Console.WriteLine(str);
            
    }
}