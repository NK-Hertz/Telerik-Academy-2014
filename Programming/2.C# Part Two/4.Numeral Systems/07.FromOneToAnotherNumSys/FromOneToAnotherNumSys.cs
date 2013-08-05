using System;

class FromOneToAnotherNumSys
{
    //Write a program to convert from any numeral system of given base s 
    //to any other numeral system of base d (2 ≤ s, d ≤  16).
    static void Main()
    {
        Console.WriteLine("Enter number of system you will convert FROM: ");
        int inputSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of system you will convert TO: ");
        int outputSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number to convert: ");
        string num = Console.ReadLine();
        string result = "";
        if (inputSystem == 10 && outputSystem == 2)
        {
            result = Convert.ToString(Convert.ToInt32(num,10),2).PadLeft(32,'0');
        }
        else if (inputSystem == 16 && outputSystem == 2)
        {
            result = Convert.ToString(Convert.ToInt32(num, 16), 2).PadLeft(32, '0'); ;
        }
        else if (inputSystem == 2 && outputSystem == 10)
        {
            result = Convert.ToString(Convert.ToInt32(num,2),10);
        }
        else if (inputSystem == 16 && outputSystem == 10)
        {
            result = Convert.ToString(Convert.ToInt32(num, 16), 10);
        }
        else if (inputSystem == 2 && outputSystem == 16)
        {
            result = Convert.ToString(Convert.ToInt32(num,2),16).ToUpper();
        }
        else if (inputSystem == 10 && outputSystem == 16)
        {
            result = Convert.ToString(Convert.ToInt32(num, 10), 16).ToUpper();
        }
        Console.WriteLine("From {0} to {1}",inputSystem,outputSystem);
        Console.WriteLine("{0} = {1}", num, result);
    }
}