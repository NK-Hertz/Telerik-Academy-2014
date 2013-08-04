using System;

class BitInAPositionIs1
{
    //Write a boolean expression that returns if the bit at position p 
    //(counting from 0) in a given integer number v has value of 1. 
    //Example: v=5; p=1  false.
    static void Main()
    {
        Console.WriteLine("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(v,2));
        int mask = 1 << p;        // na cifrata mesti na edisi koq poziciq 1(ostanalite sa 0)
        int vAndMask = v & mask;  //na mestata kudeto 2 chisla(0 ili 1) se povtarqt gi zapazva na suotventnite pozicii
        int bit = vAndMask >> p;  //slaga 1cata v nuleviq bit
        bool isOne;
        if (bit == 1)
            isOne = true;
        else
            isOne = false;
        Console.WriteLine(isOne);

    }
}