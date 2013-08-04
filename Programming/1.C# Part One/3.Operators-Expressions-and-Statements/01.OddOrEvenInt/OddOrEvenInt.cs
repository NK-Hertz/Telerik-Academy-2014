using System;

class OddOrEvenInt
{
    //Write an expression that checks if given integer is odd or even
    static void Main()
    {
        bool num = 4 % 2 == 0;
        if(num==true)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}