using System;
/*
 * Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to 
 * test this method.
 */
class HelloName
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static bool CheckName(string name)
    {
        bool isName = false;
        for (int i = 0; i < name.Length; i++)
        {
                isName = Char.IsLetter(name, i);
        }
        return isName;
    }

    static void Main()
    {
        Console.WriteLine("Hello whats your name: ");
        string name = Console.ReadLine();

        if (CheckName(name))
        {
            PrintName(name);
        }
        else
        {
            Console.WriteLine("Not a valid name!");
        }
    }
}