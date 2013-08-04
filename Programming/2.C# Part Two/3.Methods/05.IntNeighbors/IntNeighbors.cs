using System;

class IntNeighbors
{
    static void CheckTheNeighbors(int[] array, int position)
    {
        if (array[position] > array[position + 1]
            && array[position] > array[position - 1])
        {
            Console.WriteLine("{0} IS bigger than it`s neighbors!", array[position]);
        }
        else
            Console.WriteLine("{0} is NOT bigger than it`s neighbors!", array[position]);
    }

    static void CheckNeighborForLastElement(int[] array, int position)
    {
        if (array[position] > array[position - 1])
        {
            Console.WriteLine("Although this is the LAST element in the array");
            Console.WriteLine("it IS bigger than it`s neighbor!");
        }
        else
        {
            Console.WriteLine("Although this is the LAST element in the array");
            Console.WriteLine("it is NOT bigger than it`s neighbor!");
        }
    }

    static void CheckNeighborForFirstElement(int[] array, int position)
    {
        if (array[position] > array[position + 1])
        {
            Console.WriteLine("Although this is the FIRST element in the array");
            Console.WriteLine("it IS bigger than it`s neighbor!");
        }
        else
        {
            Console.WriteLine("Although this is the FIRST element in the array");
            Console.WriteLine("it is NOT bigger than it`s neighbor!");
        }
    }

    static void Main()
    {
        Console.WriteLine("Number of elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] myArray = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the position of the element to check:");
        int position = int.Parse(Console.ReadLine()) - 1;
        int wantedNum = myArray[position];
        if (position > elements || position < 0)
        {
            Console.WriteLine("There is no such position!");
        }
        else if (position == elements)
        {
            CheckNeighborForLastElement(myArray, position);
        }
        else if (position == 0)
        {
            CheckNeighborForFirstElement(myArray, position);
        }
        else
        {
            CheckTheNeighbors(myArray, position);
        }

    }
}