using System;

class Fire
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int center =  1;
        int dotsOut = (width-center)/2;
        int dotsIn = 0;
        
        for (int i = 0; i < width/2; i++)
        {
            Console.Write(new string('.', dotsOut));
            Console.Write(new string('#', center));
            Console.Write(new string('.',dotsIn));
            Console.Write(new string('#', center));
            Console.Write(new string('.', dotsOut));
            Console.WriteLine();
            dotsOut--;
            dotsIn += 2;
        }
        dotsIn = width - 2;
        dotsOut = 0;
        for (int i = 0; i < width / 4; i++)
        {
            Console.Write(new string('.', dotsOut));
            Console.Write(new string('#', center));
            Console.Write(new string('.', dotsIn));
            Console.Write(new string('#', center));
            Console.Write(new string('.', dotsOut));
            Console.WriteLine();
            dotsOut++;
            dotsIn -= 2;
        }
        for (int i = 0; i < width; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
        int leftTorch = width / 2;
        int rightTorch = width / 2;
        dotsOut = 0;
        for (int i = 0; i < width/2; i++)
        {
            Console.Write(new string('.',dotsOut));
            Console.Write(new string('\\',leftTorch));
            Console.Write(new string('/',rightTorch));
            Console.Write(new string('.', dotsOut));
            leftTorch--;
            rightTorch--;
            dotsOut++;
            Console.WriteLine();
        }
    }
}