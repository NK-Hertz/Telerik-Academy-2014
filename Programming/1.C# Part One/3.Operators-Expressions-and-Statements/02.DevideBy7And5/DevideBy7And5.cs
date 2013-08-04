using System;

class DevideBy7And5
{
    //Write a boolean expression that checks for given integer if it can be 
    //divided (without remainder) by 7 and 5 in the same time.

    static void Main()
    {
        int num=int.Parse(Console.ReadLine());
        bool result = (num % 7 ==0) && (num % 5 ==0);
        Console.WriteLine(result);
    }
}