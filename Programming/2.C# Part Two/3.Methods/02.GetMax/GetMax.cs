using System;
/*
 * Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the 
 * console and prints the biggest of them using the method GetMax().
 */
class GetMax
{
    static int GetMaxNum(int first, int second)
    {
        int max = first;
        if (max < second)
        {
            max = second;
        }
        return max;
    }

    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int maxNum = GetMaxNum(firstNum, secNum);
        maxNum = GetMaxNum(maxNum, thirdNum);
        
        Console.WriteLine(maxNum);
    }
}