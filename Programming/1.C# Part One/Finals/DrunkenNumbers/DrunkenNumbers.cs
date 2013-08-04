using System;

class DrunkenNumbers
{
    static void Main()
    {

        int rounds = int.Parse(Console.ReadLine());
        int drunkenNum = 0;
        int mitkoBeers = 0;
        int vladkoBeers = 0;
        int difference = 0;
        int totalBeers = 0;
        int numCount = 0;
        string drunken = Console.ReadLine();
        int[] array = new int[drunken.Length];
        for (int z = 0; z < drunken.Length; z++)
        {

            array[z] = (int)drunken[z] - 48;
            numCount++;
        }
        for (int i = 0; i < rounds; i++)
        {
            if (i != 0)
            {
                drunken = Console.ReadLine();
                array = new int[drunken.Length];
                for (int z = 0; z < drunken.Length; z++)
                {
                    array[z] = (int)drunken[z] - 48;
                    numCount++;
                }
            }
            if (numCount % 2 == 0)
            {
                for (int g = 0; g < numCount / 2; g++)
                {
                    mitkoBeers += array[g];
                    totalBeers += array[g];
                }
                for (int g = numCount / 2; g < numCount; g++)
                {
                    vladkoBeers += array[g];
                    totalBeers += array[g];
                }
            }
            else
            {
                for (int g = 0; g <= numCount / 2; g++)
                {
                    mitkoBeers += array[g];
                    totalBeers += array[g];
                }
                for (int g = numCount / 2; g < numCount; g++)
                {
                    vladkoBeers += array[g];
                    totalBeers += array[g];
                }
            }
            numCount = 0;
        }
        if (vladkoBeers > mitkoBeers)
        {
            difference = vladkoBeers - mitkoBeers;
            Console.WriteLine("V {0}", difference);
        }
        else if (mitkoBeers > vladkoBeers)
        {
            difference = mitkoBeers - vladkoBeers;
            Console.WriteLine("M {0}", difference);
        }
        else
        {
            Console.WriteLine("No {0}", totalBeers);
        }
    }
}

