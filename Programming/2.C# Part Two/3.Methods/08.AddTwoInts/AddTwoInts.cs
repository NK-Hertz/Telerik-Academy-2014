using System;
/* Doesn`t work correctly!
 * Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
 * the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
 */
class AddTwoInts
{
    // This only works for equal number of elements for the both arrays
    static void AddIntArrays(int[] fstArray, int[] scndArray, int[] resultArray)
    {
        for (int i = 0; i < 1; i++)
        {
            resultArray[i] = fstArray[i] + scndArray[i];
            if (fstArray[i] + scndArray[i] > 9)
            {
                resultArray[i] %= 10;
                resultArray[resultArray.Length - 1]++;
            }
        }

        for (int i = resultArray.Length - 1; i > 0; i--)
        {
            resultArray[i] += fstArray[i] + scndArray[i];
            if (fstArray[i] + scndArray[i] > 9)
            {
                resultArray[i] %= 10;
                resultArray[i - 1]++;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter lenght of the first number: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] firstArr = new int[lenght];
        for (int i = 1; i < lenght; i++)
        {
            Console.Write("first array, {0} element: ", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 1; i++)
        {
            Console.Write("first array, last element: ");
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        int[] secArr = new int[lenght];
        for (int i = 1; i < lenght; i++)
        {
            Console.Write("second array, {0} element: ", i);
            secArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 1; i++)
        {
            Console.Write("second array, last element: ");
            secArr[i] = int.Parse(Console.ReadLine());
        }

        int[] resultArray = new int[lenght];
        AddIntArrays(firstArr, secArr, resultArray);

        Console.WriteLine();

        for (int i = 0; i < lenght; i++)
        {
            Console.Write(resultArray[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("The number the way it is presented");

        for (int i = 1; i < lenght; i++)
        {
            Console.Write(resultArray[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("The right looking number");

        for (int i = 0; i < 1; i++)
        {
            Console.Write(resultArray[i]);
        }
        
    }
}