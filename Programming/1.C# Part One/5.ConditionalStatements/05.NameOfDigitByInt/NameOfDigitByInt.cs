using System;

class NameOfDigitByInt
{
    //Write program that asks for a digit and depending on the input shows the 
    //name of that digit (in English) using a switch statement.
    static void Main()
    {
        Console.WriteLine("Enter a number between 0 and 9: ");
        string n = Console.ReadLine();
        int num;
        //this is so if the input is text to return error, not exception
        bool success = int.TryParse(n, out num);
        if (success == true)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
}