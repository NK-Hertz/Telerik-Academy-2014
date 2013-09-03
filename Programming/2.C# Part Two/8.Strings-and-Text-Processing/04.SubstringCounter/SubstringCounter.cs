/* Write a program that finds how many times a substring is contained in a given text
 * (perform case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 * We are living in an yellow submarine. We don't have anything else. Inside the 
 * submarine is very tight. So we are drinking all the day. We will move out of it 
 * in 5 days.
 * The result is: 9.
 */
using System;

class SubstringCounter
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
            .ToLower();
        string target = "in";
        int index = text.IndexOf(target);
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (index >= 0)
            {
                index = text.IndexOf(target,index + 1);
                count++;
            }
            if (index < 0)
            {
                break;
            }
        }

        Console.WriteLine(count);
    }
}