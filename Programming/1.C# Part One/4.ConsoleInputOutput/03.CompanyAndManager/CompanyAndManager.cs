using System;

class CompanyAndManager
{
    //A company has name, address, phone number, fax number, web site and manager. 
    //The manager has first name, last name, age and a phone number. Write a 
    //program that reads the information about a company and its manager and 
    //prints them on the console.

    static void Main()
    {
        //  Company Info
        Console.Write("Enter company name : ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        int companyPhone = int.Parse(Console.ReadLine());
        Console.Write("Enter company fax number: ");
        int companyFax = int.Parse(Console.ReadLine());
        Console.Write("Enter company web site: ");
        string companyWebsite = Console.ReadLine();
        
        //  Manager Info
        Console.Write("Enter manager`s first name: ");
        string managerFName = Console.ReadLine();
        Console.Write("Enter manager`s last name: ");
        string managerLName = Console.ReadLine();
        Console.Write("Enter manager`s age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager`s phone number: ");
        int managerPhone = int.Parse(Console.ReadLine());

        Console.WriteLine("The {0} company is located at {1}. \nFor contacts: {2} or {3} \nIf you seek more information visit {4}",
            companyName, companyAddress, companyPhone, companyFax, companyWebsite);
        Console.WriteLine("Manager: {0} {1} \nAge: {2} \nFor contacts: {3}"
            ,managerFName,managerLName,managerAge,managerPhone);

    }
}