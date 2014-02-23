using System;

class BankProgram
{
    static void Main(string[] args)
    {
        Acount[] bankAcounts = 
        { 
            new Deposit(new IndividualCustomer("Ivan Petrov", "088812345678", "0123456987"),2545.50, 0.3),
            new Loan(new CompanyCustomer("Pesho OOD", "987465126", "Petar Ivanow"), 20000, 0.2),
            new Mortgage(new IndividualCustomer("Petar Petrov", "54169841", "9874563258"), 1534.35, 0.4)
        };

        Console.WriteLine("All Acounts:\n");
        PrintAcounts(bankAcounts);

        Console.WriteLine("\nAcounts after 500 deposit:\n");
        foreach (IDeposit acount in bankAcounts)
        {
            acount.Deposit(500);
        }

        PrintAcounts(bankAcounts);

        Console.Write("\nEnter number of months for interest: ");
        int months = int.Parse(Console.ReadLine());

        foreach (IInterest acount in bankAcounts)
        {
            Console.WriteLine
                ("The {0} has interest: {1}", acount.GetType().Name,
                acount.CalculateInterestAmount(months));
        }
    }

    static void PrintAcounts(Acount[] acounts)
    {
        foreach (IPrintable acount in acounts)
        {
            acount.PrintInfo();
        }
    }
}