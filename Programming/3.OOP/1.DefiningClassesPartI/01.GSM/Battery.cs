using System;

class Battery
{
    public string Model { get; set; }
    public double? HoursIdle { get; set; }
    public double? HoursTalked { get; set; }

    public void Print()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Battery Model: {0}", this.Model);
        Console.WriteLine("Hours Idle: {0}", this.HoursIdle);
        Console.WriteLine("Hours Talked: {0}", this.HoursTalked);
        Console.WriteLine("=========================");
    }
}