/*
 * Write a program to return the string with maximum length from an array of strings. Use LINQ.
 */
namespace _17.MaxStringLenght
{
    using System;
    using System.Linq;

    public class MaxStringLenght
    {
        public static void Main()
        {
            string[] myArr = new string[5];
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("Enter string for element[{0}]", i + 1);
                myArr[i] = Console.ReadLine();
            }
            Console.WriteLine();

            string maxLenght = myArr.OrderByDescending(str => str.Length).First();
            Console.WriteLine("The max lenght string is: {0}", maxLenght);
        }
    }
}
