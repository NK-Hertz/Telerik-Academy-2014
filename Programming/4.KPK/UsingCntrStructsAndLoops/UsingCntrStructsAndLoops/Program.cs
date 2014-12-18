namespace UsingCntrStructsAndLoops
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Task 2. A) Refactor the following if statements: 
            Potato potato;
            //... 
            if (potato != null)
            {
                if (!(potato.isWithSkin && potato.isRotten))
                {
                    Cook(potato);
                }
            }

            //Taks 2. B)
            bool originalExpression = MIN_X <= x && (x <= MAX_X && (inRangeOfY && shouldVisitCell));

            bool inRangeOfY = MIN_Y <= y && y <= MAX_Y;
            bool inRangeOfX = MIN_X <= x & x <= MAX_X;
            bool inRange = inRangeOfX && inRangeOfY && shouldVisitCell;
            if (inRange)
            {
                VisitCell();
            }

            //Task 3.Refactor the following loop:
            int expectedValue = 666;
            int numberOfElements = 100;
            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine("Element[{0}] : {1}",i, numbers[i]);
                if (i % 10 == 0 && numbers[i] == expectedValue)
                {
                    Console.WriteLine("Value Found!");
                    break;
                }
            }          
        }
    }
}
