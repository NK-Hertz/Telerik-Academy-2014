﻿using System;

class IndexBy5
{
    //Write a program that allocates array of 20 integers and initializes 
    //each element by its index multiplied by 5. Print the obtained array on
    //the console.

    static void Main()
    {
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine("array[{0}]={1}",i,array[i]);
        }
    }
}