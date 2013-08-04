using System;

class SumNs
{
    //Write a program that gets a number n and after that gets more n numbers and
    //calculates and prints their sum. 
    static void Main()
    {
        int n = 2;
        string str = null; ;
        //while loop, which continues until inputed 'no'
        while (str != "no")
        {
            Console.WriteLine("Enter new number to add: ");
            //n + new input  - becomes the new value of n;
            n += int.Parse(Console.ReadLine());
            Console.WriteLine("n ={0}",n);
            Console.WriteLine("Would you like to continue adding(n to stop/ any key to continue): ");
            str = Console.ReadLine();
        };
    }
}