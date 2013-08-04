using System;

class PBetweenNumbers
{
    //Write a program that reads two positive integer numbers and prints how 
    //many numbers p exist between them such that the reminder of the division 
    //by 5 is 0 (inclusive). Example: p(17,25) = 2.

    static void Main()
    {
        Console.WriteLine("First enter the lower number: ");
        ushort firstNum = ushort.Parse(Console.ReadLine()); // ushort for positive numbers only
        Console.WriteLine("Enter the second number: ");
        ushort secNum = ushort.Parse(Console.ReadLine()); // again as before
        int counter = 0;

        // loop for incrementing the lower number till it gets equal to the bigger number 
        for (int i = firstNum; i <= secNum; i++) 
        {
            //checking if the number is devided by 5 without remainder 
            if (i % 5 == 0)
            {
                //adding +1 to the count of numbers diveded by 5
                counter++;
                Console.WriteLine(i);
            }
        };

        Console.WriteLine("P({0},{1})={2}",firstNum,secNum,counter);
    }
}