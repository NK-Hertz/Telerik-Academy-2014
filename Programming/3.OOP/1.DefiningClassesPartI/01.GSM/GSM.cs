using System;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;

    public Battery Battery = new Battery();
    public Display Display = new Display();

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

    public void Print()
    {
        Console.WriteLine();
        Console.WriteLine("Model: {0}", this.Model);
        Console.WriteLine("Manufacturer: {0}", this.Manufacturer);
        Console.WriteLine("Price: {0}", this.Price);
        Console.WriteLine("Owner: {0}",this.Owner);
        Console.WriteLine("=========================");
    }
}