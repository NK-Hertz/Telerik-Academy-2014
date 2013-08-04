using System;

class FibonacciSequence
{
    //Write a program to print the first 100 members of the sequence of Fibonacci
    //: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
    static void Main()
    {
        //declaring an array
        int[] N = new int[100];
        for (int i = 0; i <100; i++)
        {
            //if i equals 0, the first value of N equals 0
            if(i==0)
            {
                N[i]=0;
            }
            //if i equals 1, the second value of N equals 1
            else if (i == 1)
            {
                N[i] = 1;
            }
            //if i equals any other number it follows this equation
            else
            {
                //the value is formed by the two previous values
                //N2=N1+N0    N3=N2+N1 and so on
                N[i] = N[i - 1] + N[i - 2];
            }
            //output each value of the array
            Console.WriteLine(N[i]);
        }
    }
}