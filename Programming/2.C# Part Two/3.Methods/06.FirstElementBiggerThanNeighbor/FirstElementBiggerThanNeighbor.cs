using System;

class FirstElementBiggerThanNeighbor
{
    static int CheckTheNeighbors(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1]
            && array[i] > array[i - 1])
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        return 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int elements = int.Parse(Console.ReadLine());

        Random rand = new Random();

        int[] myArray = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            //myArray[i] = int.Parse(Console.ReadLine());
            myArray[i] = rand.Next(1, 100);
        }

        int index = CheckTheNeighbors(myArray);
        Console.WriteLine("The {0} element!", index);
    }
}