using System;
using System.ComponentModel;

public enum BatteryType
{ 
    LiIon, NiMH,NiCD
}

class Battery
{
    public BatteryType Model { get;set; }
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