using System;

class DeclareCharByCode
{
    //Declare a character variable and assign it with the symbol that has Unicode
    //code 72. Hint: first use the Windows Calculator to find the hexadecimal 
    //representation of 72.

    static void Main()
    {
        char charCode = (char)0x48;
        Console.WriteLine(charCode);        
    }
}
