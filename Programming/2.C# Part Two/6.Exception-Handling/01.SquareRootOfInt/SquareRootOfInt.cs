using System;
/*Write a program that reads an integer number and calculates and prints its 
 * square root. If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
 */
class SquareRootOfInt
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
        
    }
}