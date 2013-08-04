using System;

class Primenum
{
    //Write an expression that checks if given positive integer number n 
    //(n ≤ 100) is prime. E.g. 37 is prime.
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num % 2 > 0 && num % 3 > 0 && num % 5 > 0 && num % 7 > 0 || num == 2 || num == 5 || num == 7)
            Console.WriteLine(num + " is a prime number!");

    }
}