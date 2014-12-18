using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(
                    halfPerimeter * 
                    (halfPerimeter - a) *
                    (halfPerimeter - b) *
                    (halfPerimeter - c));

            return area;
        }

        static string GetNumberAsDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid number!");
        }

        static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Array can not be null!");
            }
            if (elements.Length == 0)
            {
                throw new ArgumentException("Array must have atleast one element.");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }
            return maxElement;
        }

        static void PrintNumberWithFixedPointTwo(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        private static void PrintNumberWithRoundTripEight(object number)
        {
           Console.WriteLine("{0,8}", number);
        }

        private static void PrintNumberInPercentage(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        private static bool CheckIfHorizontal(double x1, double x2) 
        {
            bool isHorizontal = x1 == x2;

            return isHorizontal;
        }

        private static bool CheckIfVertical(double y1, double y2)
        {
            bool isVertical = y1 == y2;

            return isVertical;
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(GetNumberAsDigit(5));
            
            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintNumberWithFixedPointTwo(1.3);
            PrintNumberInPercentage(0.75);
            PrintNumberWithRoundTripEight(2.30);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            bool horizontal = CheckIfHorizontal(3, 3);
            Console.WriteLine("Horizontal? " + horizontal);
            bool vertical = CheckIfVertical(-1, 2.5);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.PersonalInformation = new PersonalInfo("Sofia", "17.03.1992" );

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.PersonalInformation = new PersonalInfo("Vidin", "03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
