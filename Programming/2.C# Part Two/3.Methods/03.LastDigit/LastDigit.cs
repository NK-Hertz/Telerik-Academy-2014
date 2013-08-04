using System;

class LastDigit
{
    static void FromNumToLetter(int num)
    {
        
        if (num == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (num == 1)
        {
            Console.WriteLine("One");
        }
        else if (num == 2)
        {
            Console.WriteLine("Two");
        }
        else if (num == 3)
        {
            Console.WriteLine("Three");
        }
        else if (num == 4)
        {
            Console.WriteLine("Four");
        }
        else if (num == 5)
        {
            Console.WriteLine("Five");
        }
        else if (num == 6)
        {
            Console.WriteLine("Six");
        }
        else if (num == 7)
        {
            Console.WriteLine("Seven");
        }
        else if (num == 8)
        {
            Console.WriteLine("Eight");
        }
        else if (num == 9)
        {
            Console.WriteLine("Nine");
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string number = Console.ReadLine();
        char[] array = new char[number.Length];
        array = number.ToCharArray();
        int lastDigit;

        for (int i = number.Length - 1; i < number.Length; i++)
        {
            lastDigit = array[i] - 48;
            FromNumToLetter(lastDigit);
        }

    }
}