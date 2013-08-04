using System;
using System.Text;

class SolveThisTasks
{
    static void ReverseDigit()
    {
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());
        StringBuilder reverseDigit = new StringBuilder();
        if (n >= 0)
        {
            while (n != 0)
            {
                int lastDigit = n % 10;
                reverseDigit.Append(lastDigit);
                int lastNum = n / 10;
                n = lastNum;

            }
            Console.Write("The number in reverse is {0}", int.Parse(reverseDigit.ToString()));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The input number can NOT be Negative!");
        }
    }

    static void CalculateAvgSum()
    {
        string nStr = string.Empty;
        decimal n;
        string stop = "STOP";
        decimal counter = 0;
        decimal sum = 0;

        Console.WriteLine("Enter your sequence of numbers");
        Console.WriteLine("When you finish write \"stop\"");
        nStr = Console.ReadLine();
        if (nStr != string.Empty)
        {
            while (nStr != stop)
            {
                nStr = Console.ReadLine();
                if (nStr.Equals(stop, StringComparison.OrdinalIgnoreCase))
                {
                    if (nStr == string.Empty)
                    {
                        Console.WriteLine("Input can NOT be Empty String");
                    }
                    break;
                }
                if (decimal.TryParse(nStr, out n))
                {
                    counter++;
                    sum = sum + n;
                }
            }
            decimal avgSum = sum / counter;
            Console.WriteLine("Avg={0:F2}", avgSum);
            Console.WriteLine();
        }
    }

    static void SolveLinearEquation()
    {

        Console.Write("a= ");
        decimal a = decimal.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("b= ");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal x = b / a;
            Console.WriteLine("a * x + b = 0");
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            Console.WriteLine(" /A/ must be greater than 0!");
        }

    }
    static void PrintMenu()
    {
        Console.WriteLine("Welcome to the Menu: ");
        Console.WriteLine();
        Console.WriteLine("Here are your choises:");
        Console.WriteLine();
        Console.WriteLine(" 1) Reverse the digits of a number");
        Console.WriteLine(" 2) Calculate the average of a sequence of integers");
        Console.WriteLine(" 3) Solve linear equation a * x + b = 0");
        Console.Write("Your choise please: ");
        int menu = int.Parse(Console.ReadLine());
        if (menu == 1)
        {
            ReverseDigit();
        }
        else if (menu == 2)
        {
            CalculateAvgSum();
        }
        else if (menu == 3)
        {
            SolveLinearEquation();
        }
        else
        {
            Console.WriteLine("Non existing option!");
        }
    }
    static void Main()
    {
        PrintMenu();
    }
}