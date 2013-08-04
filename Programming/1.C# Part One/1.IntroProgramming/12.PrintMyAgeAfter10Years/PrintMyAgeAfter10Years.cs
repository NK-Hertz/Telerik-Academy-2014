using System;

class PrintMyAgeAfter10Years
{
    static void Main()
    {
        //Write a program to read your age from the console and print 
        //how old you will be after 10 years.
        Console.WriteLine("Hello! Please insert your age: ");
        int currentAge = int.Parse(Console.ReadLine());
        currentAge += 10;
        Console.WriteLine("After 10 years you`ll be " + currentAge + " years old.");
    }
}
