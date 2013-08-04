using System;

class MarketingFirm
{
    //A marketing firm wants to keep record of its employees. Each record would 
    //have the following characteristics – first name, family name, age, gender
    //(m or f), ID number, unique employee number (27560000 to 27569999). 
    //Declare the variables needed to keep the information for a single employee
    //using appropriate data types and descriptive names.

    static void Main()
    {
        string firstName = "First";
        string familyName = "Family";
        byte age = 27;
        char gender = 'm';
        int IDNumber = 123456789;
        int employeeNumber = 27564159;
        Console.WriteLine(firstName);
        Console.WriteLine(familyName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(IDNumber);
        Console.WriteLine(employeeNumber);
    }
}
