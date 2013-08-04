﻿using System;

class TrailingZeros
{
    //Write a program that calculates for given N how many trailing zeros present
    //at the end of the number N!. Examples:
	//N = 10 -> N! = 3628800 -> 2
	//N = 20 -> N! = 2432902008176640000 -> 4
	//Does your program work for N = 50 000?
	//Hint: The trailing zeros in N! are equal to the number of its prime 
    //divisors of value 5. Think why!

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint n = uint.Parse(Console.ReadLine());
        ulong fact = 1;
        for (uint i = n; i > 1; i--)
        {
            fact *= i;
        }
        Console.WriteLine("{0}! = {1}",n, fact);
        uint trailingZeros = n / 5;
        Console.WriteLine("The trailing zeros are {0}", trailingZeros);
    }
}