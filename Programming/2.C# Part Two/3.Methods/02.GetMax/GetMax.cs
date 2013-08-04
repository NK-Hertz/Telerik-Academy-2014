using System;

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