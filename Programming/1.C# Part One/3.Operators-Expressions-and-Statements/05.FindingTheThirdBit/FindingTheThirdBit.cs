using System;

class FindingTheThirdBit
{
    //Write a boolean expression for finding if the bit 3 (counting from 0) of 
    //a given integer is 1 or 0.
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string numInBinary = Convert.ToString(num, 2);
        Console.Write(num + " = ");
        Console.WriteLine(numInBinary);
        bool result = (num / 100 % 10 == 0);
        if(result==true)
            Console.WriteLine("The bit numbered 3(counting from 0) is 0!");
        else
            Console.WriteLine("The bit numbered 3(counting from 0) is 1!");
    }
}