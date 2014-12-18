using System;
using System.Collections.Generic;


class MultiverseCommunication
{
    static int count = 0;

    static void Main()
    {
        List<string> pizzaLang = new List<string>();
        InitiateList(pizzaLang);

        string input = Console.ReadLine().ToUpper();

        List<string> inputSeparated = new List<string> ();
        int lenghtOfWord = 3;

        for (int i = 0; i < input.Length; i+=lenghtOfWord)
        {
            inputSeparated.Add(input.Substring(i,lenghtOfWord));
        }

        List<int> output = new List<int>();
        
        for (int i = 0; i < inputSeparated.Count; i++)
        {
            for (int j = 0; j < pizzaLang.Count; j++)
			{
                if (inputSeparated[i] == pizzaLang[j])
                {
                    output.Add(j) ;
                    count++;
                }
                
			}
        }

        ulong result = 0;
        int thirteenth = 1;
        for (int o = 0; o < output.Count; o++)
        {
            thirteenth = Thirteenth(count);
            result +=  (ulong)(thirteenth*output[o]);
            count--;
            thirteenth = 0;
        }

        Console.WriteLine(result);

    }

    private static int Thirteenth(int count)
    {
        int thirtheenth = 1;
        for (int i = 0; i < count - 1; i++)
        {
            thirtheenth = thirtheenth * 13;
        }

        return thirtheenth;
    }

    private static void InitiateList(List<string> pizzaLang)
    {
        pizzaLang.Add("CHU");
        pizzaLang.Add("TEL");
        pizzaLang.Add("OFT");
        pizzaLang.Add("IVA");
        pizzaLang.Add("EMY");
        pizzaLang.Add("VNB");
        pizzaLang.Add("POQ");
        pizzaLang.Add("ERI");
        pizzaLang.Add("CAD");
        pizzaLang.Add("K-A");
        pizzaLang.Add("IIA");
        pizzaLang.Add("YLO");
        pizzaLang.Add("PLA");
    }
}