using System;
using System.ComponentModel;
using System.Text;

public enum BatteryType
{ 
    LiIon, NiMH,NiCD
}

class Battery
{
    public BatteryType Model { get;set; }
    public double? HoursIdle { get; set; }
    public double? HoursTalked { get; set; }

    public override string ToString()
    {
        StringBuilder endText = new StringBuilder();
        Console.WriteLine("=========================");
        Console.WriteLine("Battery Type: " + this.Model.ToString());
        Console.WriteLine("Hours Idle: " + this.HoursIdle.ToString());
        Console.WriteLine("Hours Talked: " + this.HoursTalked.ToString());
        Console.WriteLine("=========================");
        return endText.ToString();
    }
}