using System;
/*
 * Write a method that reverses the digits of given decimal number. Example: 256 > 652
 */
class DigitReverser
{
    static string ReverseDigits(char[] array)
    {
        string newNumber = "";
        for (int i = array.Length -1 ; i >= 0; i--)
        {
            newNumber += array[i];
        }
        return newNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string number = Console.ReadLine();

        char[] myArray = new char[number.Length];
        myArray = number.ToCharArray();

        string newNum = ReverseDigits(myArray);
        Console.WriteLine(newNum);


    }
}