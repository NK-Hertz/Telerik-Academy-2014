/*Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
*/ 
using System;

class BracketChecker
{
    static void Main()
    {
        Console.WriteLine("Enter expression: ");
        string expression = Console.ReadLine();

        int brackets = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets++;
            }
            if (expression[i] == ')')
            {
                brackets--;
            }
            if (brackets < 0)
            {
                break;
            }
        }

        if (brackets == 0)
        {
            Console.WriteLine("The entered expression is correct!");
        }
        else
        {
            Console.WriteLine("The entered expression is NOT correct!");
        }
    }
}