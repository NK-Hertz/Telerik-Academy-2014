using System;

class Calculate
{
    static int Minimum(int[] array)
    {

        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int Maximum(int[] array)
    {

        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static double Average(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    static long Sum(int[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static long Product(int[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements?");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];

        for (int i = 0; i < elements; i++)
        {
            Console.Write("element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The minimum is {0}", Minimum(array));
        Console.WriteLine("The maxmimum is {0}", Maximum(array));
        Console.WriteLine("The average number is {0}", Average(array));
        Console.WriteLine("The sum is {0}", Sum(array));
        Console.WriteLine("The product is {0}", Product(array));
    }
}