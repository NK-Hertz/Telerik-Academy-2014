using System;

class GSM
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public string Owner { get; set; }

    public Battery Battery = new Battery();
    public Display Display = new Display();

    public GSM()
    { 
    }

    public GSM(string Model, string Manufacturer)
        : this(Model, Manufacturer, 0, null)
    { 
    }

    public GSM(string Model, string Manufacturer, decimal Price, string Owner)
    {
        this.Model = Model;
        this.Manufacturer = Manufacturer;
        this.Price = Price;
        this.Owner = Owner; 
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