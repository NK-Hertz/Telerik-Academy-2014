using System;

class AddTwoInts
{
    // Tova e variant koito raboti pri ednakuv broi elementi i na 2ta masiva
    // i ako ne nadminava sbor po golqm ot 99 999 ili po golqm broi devetki
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
        for (int i = 0; i < 1; i++)
        {
            Console.Write(resultArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The right looking number");
    }
}