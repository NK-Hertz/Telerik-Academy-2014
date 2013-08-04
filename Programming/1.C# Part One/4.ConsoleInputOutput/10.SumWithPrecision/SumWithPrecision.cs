using System;
using System.Threading;
using System.Globalization;

class SumWithPrecision
{
    //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 
    //1/3 + 1/4 - 1/5 + ...
    static void Main()
    {
        double sum = 1;
        //change the value 10 if you want to sum further
        for (int i = 2; i <= 10; i++)
        {
            // if i is even, this equation
            if(i%2==0)
                sum = sum + (1.0 / i);
            //if i is odd, this one
            else
                sum = sum - (1.0 / i);
        }
        //output the value of sum, with precision 3 numbers after the decimal mark
        Console.WriteLine("{0:0.000}",sum);
    }
}