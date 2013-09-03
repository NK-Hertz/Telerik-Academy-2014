/* Write a program that reads from the console a string of maximum 20 characters. If 
 * the length of the string is less than 20, the rest of the characters should be 
 * filled with '*'. Print the result string into the console.
*/
using System;

class MaxLengthOfStr20
{
    static void Main()
    {
        Console.WriteLine("Enter string with max length 20 chars: ");
        string text = Console.ReadLine();
        int maxLength = 20;
        int lastPostion = text.Length;
        if (lastPostion < maxLength)
        {
            while (lastPostion < maxLength)
            {
                text = text.Insert(lastPostion, "*");
                lastPostion++;
            }
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Good job!Exactly 20 characters entered!");
        }
    }
}