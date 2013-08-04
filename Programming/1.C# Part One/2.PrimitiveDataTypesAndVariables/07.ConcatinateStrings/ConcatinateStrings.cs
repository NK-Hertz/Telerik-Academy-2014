using System;

class ConcatinateStrings
{
    //Declare two string variables and assign them with “Hello” and “World”. 
    //Declare an object variable and assign it with the concatenation of the 
    //first two variables (mind adding an interval). Declare a third string 
    //variable and initialize it with the value of the object variable 
    //(you should perform type casting).

    static void Main()
    {
        string helloStr = "Hello";
        string worldStr = "World";
        object concatObject = helloStr + " " + worldStr;
        string finalStr = (string) concatObject;
        Console.WriteLine(helloStr);
        Console.WriteLine(worldStr);
        Console.WriteLine(concatObject);
        Console.WriteLine(finalStr);
    }
}