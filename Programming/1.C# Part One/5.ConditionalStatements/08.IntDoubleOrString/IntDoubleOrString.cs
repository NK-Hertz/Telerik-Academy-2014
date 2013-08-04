using System;
using System.Threading;
using System.Globalization;

class IntDoubleOrString
{
    //Write a program that, depending on the user's choice inputs int, double or
    //string variable. If the variable is integer or double, increases it with 1.
    //If the variable is string, appends "*" at its end. The program must show 
    //the value of that variable as a console output. Use switch statement.

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter what kind of variable you want\n(1-int, 2-double, 3-string):");
        sbyte num = sbyte.Parse(Console.ReadLine());
        switch (num)
        { 
            case 1:
                Console.WriteLine("Enter integer:");
                int @int = int.Parse(Console.ReadLine());
                @int = @int + 1;
                Console.WriteLine("New value of the integer: {0}",@int);
                break;
            case 2:
                Console.WriteLine("Enter double:");
                double @double = double.Parse(Console.ReadLine());
                @double = @double + 1;
                Console.WriteLine("New value of the double: {0}", @double);
                break;
            case 3:
                Console.WriteLine("Enter string:");
                string str = Console.ReadLine();
                str = str + "*";
                Console.WriteLine("The new string is {0}",str);
                break;
            default:
                Console.WriteLine("Error");
                break;
        }

    }
}