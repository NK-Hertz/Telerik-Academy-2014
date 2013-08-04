using System;

class DeckOfCards
{
    //Write a program that prints all possible cards from a standard deck of 52
    //cards (without jokers). The cards should be printed with their English 
    //names. Use nested for loops and switch-case.

    static void Main()
    {
        Console.WriteLine("Enter suit:(spades,hearts,diamonds or clubs)=");
        //from 0 to 4 becouse we have 4 suits
        for (int z = 0; z < 4; z++)
        {
            string suits = Console.ReadLine();
            switch (suits)
            {
                case "spades":
                case "hearts":
                case "diamonds":
                case "clubs":
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            for (int i = 2; i < 11; i++)
                            {
                                //from 2-10
                                Console.WriteLine(i + " of " + suits);
                            }
                            //and the rest
                            Console.WriteLine("Jack of {0}", suits);
                            Console.WriteLine("Queen of {0}", suits);
                            Console.WriteLine("King of {0}", suits);
                            Console.WriteLine("Ace of {0}", suits);
                        }
                        Console.WriteLine();
                        break;
                    }
            }
        }
    }
}