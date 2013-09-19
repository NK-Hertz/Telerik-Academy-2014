using System;
/*
 * Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */
class SequenceOfEqualElements
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of the array: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.WriteLine("Enter {0} element:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sequence = 1;
        int maxSequence = 1;
        int position = 1;
        for (int i = 1; i < lenght; i++)
        {
            if (array[i] == array[i - 1])
            {
                sequence++;
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    position = i - sequence;
                }
            }
            else
            {
                sequence = 1;
            }
        }
        for (int i = position + 1; i < position + maxSequence + 1; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The biggest sequence of equal elements is = {0}", maxSequence);

    }
}