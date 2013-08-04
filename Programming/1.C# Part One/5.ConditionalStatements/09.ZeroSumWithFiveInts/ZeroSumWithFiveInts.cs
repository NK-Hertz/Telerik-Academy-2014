using System;

class ZeroSumWithFiveInts
{
    //We are given 5 integer numbers. Write a program that checks if the sum of 
    //some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
    static void Main()
    {
        int[] arr = new int[5];
        //bucket is my temporary container
        int bucket=0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter value: ");
            arr[i] = int.Parse(Console.ReadLine());
            bucket+=arr[i];
        }
        //if the sum is equal to 0
        if (bucket == 0)
        {
            Console.WriteLine("There is subset, which equals zero");
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                Console.WriteLine("There is an element equal to zero.");
                break;
            }
        }
        //sums the elements
        for (int i = 0; i < arr.Length-2; i++)
        {
            for (int x = i+1; x < arr.Length; x++)
            {
                if (arr[i] + arr[x] == 0)
                {
                    Console.WriteLine("{0}, {1}", arr[i], arr[x]);
                }
                for (int y = x+1; y < arr.Length; y++)   
                {
                    if (arr[i] + arr[x] + arr[y] == 0)
                    {
                        Console.WriteLine("{0}, {1}, {2}", arr[i], arr[x], arr[y]);
                    }
                    for (int z = y+1; z < arr.Length; z++)
                    {
                        if (arr[i] + arr[x] + arr[y] + arr[z] == 0)
                        {
                            Console.WriteLine("{0}, {1}, {2}, {3}",arr[i],arr[x],arr[y],arr[z]);
                        }
                    }
                }
            }
        }

    }
}