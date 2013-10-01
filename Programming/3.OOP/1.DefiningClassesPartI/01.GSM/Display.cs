using System;

class Display
{
    public uint? Size { get; set; }
    public string Colours { get; set; }

    public void Print()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Size: {0}\"", this.Size);
        Console.WriteLine("Colours: {0}", this.Colours);
        Console.WriteLine();
    }


}