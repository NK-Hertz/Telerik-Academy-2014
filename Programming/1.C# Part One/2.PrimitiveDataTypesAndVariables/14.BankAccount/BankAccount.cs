using System;

class BankAccount
{
    //A bank account has a holder name (first name, middle name and last name), 
    //available amount of money (balance), bank name, IBAN, BIC code and 3 credit
    //card numbers associated with the account. Declare the variables needed to 
    //keep the information for a single bank account using the appropriate data 
    //types and descriptive names.

    static void Main()
    {
        string holderName = "First, Middle, Last Name";
        //string firstName = "First Name";
        //string middleName = "Middle Name";
        //string lastName = "Last Name";
        decimal balance = 4294967295;
        string bankName = "Bank Name";
        string iban = "34 alphanumeric characters";
        string bic = "8 alphanumeric characters";
        ulong OBBCreditCardNumber= 1234567890001234;
        ulong MKBCreditCardNumber = 1234567890001234;
        ulong GeneralExpressCreditCardNumber = 1234567890001234;
        Console.WriteLine(holderName);
        Console.WriteLine("An appropriate balance: " + balance);
        Console.WriteLine(bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("BIC: " + bic);
        Console.WriteLine("Credit Card Number OBB: " + OBBCreditCardNumber);
        Console.WriteLine("Credit Card Number MKB: " + MKBCreditCardNumber);
        Console.WriteLine("Credit Card Number GeneralExpress: " + GeneralExpressCreditCardNumber);
    }
}
