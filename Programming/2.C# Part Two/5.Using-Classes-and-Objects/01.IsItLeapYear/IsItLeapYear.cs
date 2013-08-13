using System;

//Write a program that reads a year from the console and checks whether 
//it is a leap. Use DateTime.


class IsItLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT a leap year.", year);
        }
    }
}