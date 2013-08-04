using System;

class TriangleCopyRight
{
    //Write a program that prints an isosceles triangle of 9 copyright symbols ©.
    //Use Windows Character Map to find the Unicode code of the © symbol. 
    //Note: the © symbol may be displayed incorrectly.

    static void Main()
    {
        string copyRight = "\u00A9";
        Console.WriteLine("  "+copyRight);
        Console.WriteLine(" " + copyRight + copyRight + copyRight);
        Console.WriteLine(copyRight + copyRight + copyRight + copyRight + copyRight);
    }
}