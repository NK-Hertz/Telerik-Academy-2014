using System;

class PrintFirst10MembersOfSequence
{
    static void Main()
    {
        //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
        int firstMember = 2;
        Console.WriteLine(firstMember);
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(firstMember + i);
            }
            else 
            {
                Console.WriteLine((firstMember + i) *-1);
            }
        }
    }
}