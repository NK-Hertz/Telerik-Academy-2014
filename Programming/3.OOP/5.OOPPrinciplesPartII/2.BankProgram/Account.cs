using System;

public abstract class Acount : IInterest, IDeposit, IPrintable
{
    // Fields
    private Customer customer;
    private double balance;
    private double interestRate;

    // Constructor
    public Acount()
        : this(new Customer(), 0, 0) { }

    public Acount(Customer customer, double balance, double interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    // Properties
    public Customer Customer
    {
        get { return this.customer; }
        protected set
        {
            if (value == null)
            {
                Console.WriteLine("Enter customer!");
            }
            this.customer = value;
        }
    }

    public double Balance
    {
        get { return this.balance; }
        protected set
        {
            this.balance = value;
        }
    }

    public double InterestRate
    {
        get { return this.interestRate; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            this.interestRate = value;
        }
    }

    // Methods
    public virtual double CalculateInterestAmount(int months)
    {
        return months * this.interestRate * this.balance / 100;
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException();
        }
        this.Balance += amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine("{0} {1} Balance: {2} Interest for 2 years: {3}",
            this.GetType().Name, customer.Name, this.balance, this.CalculateInterestAmount(24));
    }
}