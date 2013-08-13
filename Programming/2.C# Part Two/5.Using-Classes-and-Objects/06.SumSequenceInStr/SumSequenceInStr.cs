using System;

/*You are given a sequence of positive integer values written into a string, 
 * separated by spaces. Write a function that reads these values from given
 * string and calculates their sum. 
 * Example:string = "43 68 9 23 318"  result = 461
*/
class SumSequenceInStr
{
    static void Main()
    {
        Console.WriteLine("Enter sequence: ");
        string[] sequenceArr = Console.ReadLine().Split(' ');
        int[] sequenceInt = new int[sequenceArr.Length];
        for (int i = 0; i < sequenceArr.Length; i++)
        {
            sequenceInt[i] = int.Parse(sequenceArr[i]);
        }

        int result = 0;
        for (int i = 0; i < sequenceArr.Length; i++)
        {
            result +=sequenceInt[i];
        }
        Console.WriteLine(result);
    }
}