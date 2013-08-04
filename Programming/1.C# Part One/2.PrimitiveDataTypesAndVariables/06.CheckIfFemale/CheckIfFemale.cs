using System;

class CheckIfFemale
{
    //Declare a boolean variable called isFemale and assign
    //an appropriate value corresponding to your gender.
    static void Main()
    {
        Console.WriteLine("Are you female or male?");
        string gender = Console.ReadLine();
        bool isFemale;
        if (gender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("Are you a female: " + isFemale);
    }
}