using System;
using System.Linq;
/*
 * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */
public class DevisibleBy7And3
{
    public static void Main()
    {
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        //var selectedNums =
        //numbers.Where(x => x % 21 == 0);

        var selectedNums =
        from num in numbers
        where num % 21 == 0
        select num;

        foreach (var num in selectedNums)
        {
            Console.WriteLine(num);
        }
    }
}