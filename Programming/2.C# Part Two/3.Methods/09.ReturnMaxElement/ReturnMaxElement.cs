using System;
/*
 * Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another 
 * method that sorts an array in ascending / descending order.
 */
class ReturnMaxElement
{
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void SortArrayDes(int[] array)
    {
        int biggest;
        for (int i = 0; i < array.Length; i++)
        {
            biggest = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[biggest] < array[j])
                {
                    biggest = j;
                }
            }
            int bucket = array[biggest];
            array[biggest] = array[i];
            array[i] = bucket;
        }  
    }

    static void SortArrayAsc(int[] array)
    {
        int smallest;
        for (int i = 0; i < array.Length; i++)
        {
            smallest = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[smallest] > array[j])
                {
                    smallest = j;
                }
            }
            int bucket = array[smallest];
            array[smallest] = array[i];
            array[i] = bucket;
        }      
    }

    static int MaxElement(int[] array, int startIndex, int endIndex)
    {
        int biggestElement = 0;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (array[i] > biggestElement)
            {
                biggestElement = array[i];
            }
        }
        return biggestElement;
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int elements = int.Parse(Console.ReadLine());
        int[] myArray = new int[elements];

        Random rand = new Random();

        for (int i = 0; i < elements; i++)
        {
            myArray[i] = rand.Next(1, 500);
            Console.Write(myArray[i] + " ");
            //Console.Write("{0} element: ",i + 1);
            //myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Select starting index: ");
        int startIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Select ending index: ");
        int endIndex = int.Parse(Console.ReadLine());

        int maxElement = MaxElement(myArray, startIndex, endIndex);
        Console.WriteLine("{0} is the max element between {1} and {2}"
            ,maxElement,startIndex,endIndex);


        SortArrayAsc(myArray);
        Console.WriteLine("Ascending: ");
        PrintArray(myArray);

        SortArrayDes(myArray);
        Console.WriteLine("Descending: ");
        PrintArray(myArray);
    }
}