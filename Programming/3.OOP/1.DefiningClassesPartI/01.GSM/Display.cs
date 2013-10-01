using System;

class Display
{
    //encapsulation
    private uint? size;
    private uint colours;

    public uint? Size 
    {
        get { return this.size; }
        set
        {
            this.size = value;

            if (size <= 0 )
            {
                throw new ArgumentException("Size must be positive number!");
            }
        }
    }

    public uint Colours
    {
        get { return this.colours; }
        set 
        {
            this.colours = value;
            if (value < 0)
            {
                throw new ArgumentException("Colours must be positive!");
            }
        }
    }

    //print all information about Display class
    public void Print()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Size: {0}\"", this.Size);
        Console.WriteLine("Colours: {0}", this.Colours);
        Console.WriteLine();
    }
}