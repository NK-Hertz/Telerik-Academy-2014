using System;
/* Write a method ReadNumber(int start, int end) that enters an integer number 
 * in given range [start…end]. If an invalid number or non-number text is 
 * entered, the method should throw an exception. Using this method write a 
 * program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
class TenNumbers
{
    static int count = 0;

    static int ReadNumber(int start, int end)
    {
        int value;
        try
        {
            Console.WriteLine("Enter number: ");
            value = int.Parse(Console.ReadLine());
            if (value < start || value > end)
            {
                throw new ArgumentOutOfRangeException(
                    "Number must be between the given range!");
            }
            if (count == 10)
            {
                return value;
            }

            count++;
        }
        catch (FormatException fe)
        {
            Console.WriteLine("The input has to be a number!" + fe.Message);
            throw;
        }

        return ReadNumber(value, end);
    }

    static void Main()
    {
        ReadNumber(1, 100);
    }
}