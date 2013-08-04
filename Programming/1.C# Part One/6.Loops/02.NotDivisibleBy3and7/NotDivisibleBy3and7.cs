using System;

class NotDivisibleBy3and7
{
    //Write a program that prints all the numbers from 1 to N, that are not 
    //divisible by 3 and 7 at the same time.

    static void Main()
    {
        Console.Write("n= ");
        int num = int.Parse(Console.ReadLine());
       
        for (int i = 1; i <= num; i++)
        {
            bool devisible = i % 3 == 0 && i % 7 == 0;
            if (devisible == false)
            {
                Console.WriteLine(i);
            }
        }
    }
}