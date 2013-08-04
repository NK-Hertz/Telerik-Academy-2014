using System;

class SwitchValuesIf
{
    //Write an if statement that examines two integer variables and exchanges 
    //their values if the first one is greater than the second one.

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("a={0} & b={1}",a,b);
    }
}