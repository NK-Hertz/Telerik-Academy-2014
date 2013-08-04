using System;

class NumToText
{
    //Write a program that converts a number in the range [0...999] to a text 
    //corresponding to its English pronunciation. Examples:
	//0 - "Zero"
	//273 - "Two hundred seventy three"
	//400 - "Four hundred"
	//501 - "Five hundred and one"
	//711 - "Seven hundred and eleven"


    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string ones = "";
        string tens = "";
        string hundreds = "";
        string special = "";
        bool specialActive = false;
        int bucket = num / 100;
        int bucketTens = num / 10 % 10;
        int bucketOnes = num % 10 % 10;

            //hundreds
            if (bucket == 1)
            {
                ones = "One";
            }
            else if (bucket == 2)
            {
                ones = "Two";
            }
            else if (bucket == 3)
            {
                ones = "Three";
            }
            else if (bucket == 4)
            {
                ones = "Four";
            }
            else if (bucket == 5)
            {
                ones = "Five";
            }
            else if (bucket == 6)
            {
                ones = "Six";
            }
            else if (bucket == 7)
            {
                ones = "Seven";
            }
            else if (bucket == 8)
            {
                ones = "Eight";
            }
            else if (bucket == 9)
            {
                ones = "Nine";
            }

            if (bucket != 0)
            {
                hundreds = ones + " hundred";
                Console.Write(hundreds);
            }
        // tens
            if (bucketTens == 1)
            {
                //11-19
                if (num % 10 == 1)
                {
                    special = "Eleven";
                    specialActive = true;
                }
                else if (num % 10 == 2)
                {
                    special = "Twelve";
                    specialActive = true;
                }
                else if (num % 10 == 3)
                {
                    special = "Thirteen";
                    specialActive = true;
                }
                else if (num % 10 == 4)
                {
                    special = "Fourteen";
                    specialActive = true;
                }
                else if (num % 10 == 5)
                {
                    special = "Fifteen";
                    specialActive = true;
                }
                else if (num % 10 == 6)
                {
                    special = "Sixteen";
                    specialActive = true;
                }
                else if (num % 10 == 7)
                {
                    special = "Seventeen";
                    specialActive = true;
                }
                else if (num % 10 == 8)
                {
                    special = "Eighteen";
                    specialActive = true;
                }
                else if (num % 10 == 9)
                {
                    special = "Nineteen";
                    specialActive = true;
                }
                else
                    tens = "Ten";
            }
            else if (bucketTens == 2)
            {
                tens = "Twenty";
            }
            else if (bucketTens == 3)
            {
                tens = "Thirty";
            }
            else if (bucketTens == 4)
            {
                tens = "Fourty";
            }
            else if (bucketTens == 5)
            {
                tens = "Fifty";
            }
            else if (bucketTens == 6)
            {
                tens = "Sixty";
            }
            else if (bucketTens == 7)
            {
                tens = "Seventy";
            }
            else if (bucketTens == 8)
            {
                tens = "Eighty";
            }
            else if (bucketTens == 9)
            {
                tens = "Ninety";
            }
            Console.Write(" " + tens);
           
        if (specialActive == true)
            {
                Console.Write(" " + special);
                Console.WriteLine();
            }
        else
            { 
            //ones
            if (bucketOnes == 1)
            {
                ones = "One";
            }
            else if (bucketOnes == 2)
            {
                ones = "Two";
            }
            else if (bucketOnes == 3)
            {
                ones = "Three";
            }
            else if (bucketOnes == 4)
            {
                ones = "Four";
            }
            else if (bucketOnes == 5)
            {
                ones = "Five";
            }
            else if (bucketOnes == 6)
            {
                ones = "Six";
            }
            else if (bucketOnes == 7)
            {
                ones = "Seven";
            }
            else if (bucketOnes == 8)
            {
                ones = "Eight";
            }
            else if (bucketOnes == 9)
            {
                ones = "Nine";
            }
            else
            {
                ones = "";    
            }

            Console.Write(" " + ones);
            Console.WriteLine();
            }
        //if any of the buckets are 0 then 
        if (bucket == 0 && bucketTens == 0 && bucketOnes == 0)
        {
            Console.WriteLine("Zero");
        }
    }
}
