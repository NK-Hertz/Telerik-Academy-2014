using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] array = new bool[10000001];
        int j = 2;
        for (int i = 2; i * i < array.Length;)
        {
            while (i + j <= array.Length - 1)
            {
                i = i + j;
                array[i] = true;
            }
             j++;                                   
            if (!array[j])              
                i = j;                         
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (!array[i] && i > 1)        
            {                
                Console.Write(i + " ");    
            }
        }
    }
}
       