using System;

class NewNEqualsBinaryFromOldN
{
    //We are given integer number n, value v (v=0 or 1) and a position p. Write a
    //sequence of operators that modifies n to hold the value v at the position p
    //from the binary representation of n.	
    //Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	//n = 5 (00000101), p=2, v=0 -> 1 (00000001)

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        sbyte p = sbyte.Parse(Console.ReadLine());
        sbyte v = sbyte.Parse(Console.ReadLine());
        //modifies n to hold the value v at the 
        //position p from the binary representation of n
        if (v == 1)
        {
            int mask = v << p;//slaga V na poziciq P
            n = n | mask;
        }
        else
        {
            int mask = ~(1 << p);
            n = n & mask;
        }
        Console.Write("{0}==", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0'));
    }
}