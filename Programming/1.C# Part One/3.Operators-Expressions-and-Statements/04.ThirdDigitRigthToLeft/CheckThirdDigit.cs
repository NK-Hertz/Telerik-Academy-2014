using System;

class CheckThirdDigit
{
    //Write an expression that checks for given integer if its third digit 
    //(right-to-left) is 7. E. g. 1732  true.
    static void Main()
    {
        int num = 1723 / 100 % 10;
        Console.WriteLine(num);
    }
}