using System;

class ArrayOfStrings
{
    //definiran e tuk za da moje da se izpolzva navsqkude
    public static int elements;

    static void CompareStringsNow(string[] myArray)
    {
        int[] byLength = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            byLength[i] = myArray[i].Length;
        }
        Array.Sort(byLength, myArray);
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        elements = int.Parse(Console.ReadLine());

        string[] myArray = new string[elements];
        //vuvejdane na masiva
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Enter {0} element: ",i);
            myArray[i] = Console.ReadLine();
        }
        Console.WriteLine();
        //izvikvane na metoda
        CompareStringsNow(myArray);
        Console.WriteLine("The new order is: ");
        //izpisvane na podredeniq masiv
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}