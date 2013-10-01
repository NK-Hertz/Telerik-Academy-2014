using System;
using System.Collections.Generic;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;

    public Battery Battery = new Battery();
    public Display Display = new Display();

    private List<Call> callHistory = new List<Call>();

    public GSM()
    { 
    }

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, 0, null)
    { 
    }

    public GSM(string model, string manufacturer, double price, string owner)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner; 
    }

    //static
    public static readonly GSM IPhone4S = new GSM("IPhone 4S", "Apple", 1000, "Veso");

    public string Model 
    {
        get { return this.model; }
        set 
        {
            this.model = value;

            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("The model cannot be empty");
            }
        }
    }

    public string Manufacturer 
    {
        get { return this.manufacturer; }
        set 
        {
            this.manufacturer = value;
            if (string.IsNullOrEmpty(manufacturer))
            {
                throw new ArgumentException("The manufacturer cannot be empty");
            }
        }
    }

    public double Price
    {
        get { return this.price; }
        set 
        {
            this.price = value;

            if (price < 0)
            {
                throw new ArgumentException("The price must be a positive!");
            }
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }

    public void Print()
    {
        Console.WriteLine();
        Console.WriteLine("Model: {0}", this.Model);
        Console.WriteLine("Manufacturer: {0}", this.Manufacturer);
        Console.WriteLine("Price: {0}", this.Price);
        Console.WriteLine("Owner: {0}",this.Owner);
        Console.WriteLine("=========================");
    }

    public void AddCall(string dialedNumber, uint duration)
    {
        Call addNewCall = new Call(dialedNumber, duration);
        this.callHistory.Add(addNewCall);
    }

    public void DeleteCall(int index)
    {
        if (index < this.callHistory.Count && index > -1)
        {
            this.callHistory.RemoveAt(index);
        }
        else
        {
            throw new ArgumentException("The index must be real!");
        }
    }

    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    public double CalcPrice(double pricePerMin)
    {
        uint minutes = 0;
        uint reminder = 0;

        for (int i = 0; i < this.callHistory.Count; i++)
        {
            minutes += callHistory[i].Duration / 60;
            reminder = callHistory[i].Duration % 60;

            if (reminder != 0)
            {
                minutes++;
            }
        }

        return minutes * pricePerMin;
    }

}