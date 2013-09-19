using System;
using System.Linq;
/*
 * Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
 * x2 + 5 = 1x2 + 0x + 5 > 5 0 1

 * Extend the program to support also subtraction and multiplication of polynomials.
 */
class MultriFunctionWithArrays
{
    static decimal[] PutIndexInArr(decimal[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {

            decimal num = decimal.Parse(Console.ReadLine());
            arr[i] = num;
        }
        Array.Reverse(arr);
        return arr;
    }

    static decimal[] SumTwoArrays(decimal[] arr1, decimal[] arr2)
    {

        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }

        decimal[] sumArr = new decimal[biggerLength];

        for (int i = 0; i < biggerLength; i++)
        {
            if (i > smallerLength - 1)
            {
                sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                sumArr[i] = arr1[i] + arr2[i];
            }

        }
        return sumArr;
    }

    static decimal[] SubstractArrays(decimal[] arr1, decimal[] arr2)
    {

        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }

        decimal[] sumArr = new decimal[biggerLength];

        for (int i = 0; i < biggerLength; i++)
        {
            if (i > smallerLength - 1)
            {
                sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                sumArr[i] = arr1[i] - arr2[i];
            }
        }
        return sumArr;
    }

    static decimal[] MultiplyArr(decimal[] arr1, decimal[] arr2)
    {
        decimal[] multiArr = new decimal[arr1.Length + arr2.Length - 1];
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                multiArr[i + j] += arr1[i] * arr2[j];
            }

        }
        return multiArr;
    }

    static string ReturnPositiveSign(decimal[] arr, int i)
    {
        if (arr[i] > 0 && arr.Length - 1 != i)
        {
            string signPlus = "+";
            return signPlus;
        }
        else
        {
            return string.Empty;
        }
    }

    static void PrintPolynom(decimal[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != 0)
            {
                if (i != 0 && i != 1)
                {
                    Console.Write(" {2}{0:F1}x^{1}", arr[i], i, ReturnPositiveSign(arr, i));
                }
                else if (i == 1)
                {
                    Console.Write(" {1}{0:F1}x", arr[i], ReturnPositiveSign(arr, i));

                }
                else if (i == 0)
                {
                    Console.Write(" {1}{0:F1}", arr[i], ReturnPositiveSign(arr, i));
                }
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter degree of your 1 polynomial:");
        int degree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
        decimal[] arr1 = new decimal[degree + 1];
        PutIndexInArr(arr1);

        Console.Write("Enter degree of your 2 polynomial:");
        degree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
        decimal[] arr2 = new decimal[degree + 1];
        PutIndexInArr(arr2);
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Array 1:                 ");
        PrintPolynom(arr1);
        Console.Write("Array 2:                 ");
        PrintPolynom(arr2);
        Console.WriteLine();

        Console.Write("Sum:                     ");
        PrintPolynom(SumTwoArrays(arr1, arr2));


        Console.Write("Subtraction:             ");
        PrintPolynom(SubstractArrays(arr1, arr2));


        Console.Write("Multiplication:          ");
        PrintPolynom(MultiplyArr(arr1, arr2));
        Console.WriteLine();
        Console.WriteLine();
    }
}