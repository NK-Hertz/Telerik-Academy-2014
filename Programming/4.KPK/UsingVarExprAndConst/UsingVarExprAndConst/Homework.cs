namespace UsingVarExprAndConst
{
    using System;

    class Homework
    {
        static void Main(string[] args)
        {
        }

        public void PrintMaximum(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("The maximum is: {0}", max);
        }

        public void PrintMinimum(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("The minimum is: {0}",min);
        }

        public void PrintAverage(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            double average = sum / numbers.Length;
            Console.WriteLine("The average is: {0}",average);
        }
    }
}
