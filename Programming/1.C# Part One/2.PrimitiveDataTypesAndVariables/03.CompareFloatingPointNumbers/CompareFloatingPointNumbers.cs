using System;

class CompareFloatingPointNumbers
{
    //Write a program that safely compares floating-point numbers with precision
    //of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

    static void Main()
    {
        Console.WriteLine("First number: ");
        decimal firstValue = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Second number: ");
        decimal secondValue = decimal.Parse(Console.ReadLine());
        if (firstValue > secondValue)
        {
            Console.WriteLine(firstValue + " is greater!");
        }
        else
        {
            Console.WriteLine(secondValue + " is greater!");
        }
    }
}