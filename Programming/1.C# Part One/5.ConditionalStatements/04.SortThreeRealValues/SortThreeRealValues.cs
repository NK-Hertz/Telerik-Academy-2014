using System;

class SortThreeRealValues
{
    //Sort 3 real values in descending order using nested if statements.
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("a={0}",a);
            if (b > c)
            {
                Console.WriteLine("b={0}", b);
                Console.WriteLine("c={0}", c);
            }
            else
            {
                Console.WriteLine("c={0}", c);
                Console.WriteLine("b={0}", b);
            }
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("b={0}", b);
            if (a > c)
            {
                Console.WriteLine("a={0}", a);
                Console.WriteLine("c={0}", c);
            }
            else
            {
                Console.WriteLine("c={0}", c);
                Console.WriteLine("a={0}", a);
            }
        }
        else
        {
            Console.WriteLine("c={0}", c);
            if (a > b)
            {
                Console.WriteLine("a={0}", a);
                Console.WriteLine("b={0}", b);
            }
            else
            {
                Console.WriteLine("b={0}", b);
                Console.WriteLine("a={0}", a);
            }
        }
    }
}