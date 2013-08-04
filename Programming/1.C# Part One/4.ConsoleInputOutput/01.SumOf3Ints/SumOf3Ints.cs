using System;

class SumOf3Ints
{
    //Write a program that reads 3 integer numbers from the console and prints 
    //their sum.

    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2} = {3}", firstNum, secNum, thirdNum, firstNum + secNum + thirdNum);
    }
}