using System;

class PrintMinAndMax
{
    //Write a program that reads from the console a sequence of N integer numbers
    //and returns the minimal and maximal of them.

    static void Main()
    {
        Console.Write("Enter how many numbers you want: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int max = number;
        int min = number;
        for (int i = 1; i < n; i++)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (max < number)
            {
                max = number;
            }
            else if (min > number)
            {
                min = number;
            }
        }
        Console.WriteLine("Max={0}", max);
        Console.WriteLine("Min={0}", min);
    }
}