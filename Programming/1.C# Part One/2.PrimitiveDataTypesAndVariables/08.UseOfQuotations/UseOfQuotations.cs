using System;

class UseOfQuotations
{
    //Declare two string variables and assign them with following value:
    //The "use" of quotations causes difficulties.
	//Do the above in two different ways: with and without using quoted strings.

    static void Main()
    {
        string quatation="The \"use\" of quotation causes difficulties.";
        string quatationPrefix=@"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quatation);
        Console.WriteLine(quatationPrefix);
    }
}