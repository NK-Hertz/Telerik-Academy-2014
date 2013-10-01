using System;
using System.ComponentModel;
using System.Text;

public enum BatteryType
{ 
    LiIon, NiMH,NiCD
}

class Battery
{
    private BatteryType model;
    private double? hoursIdle;
    private double? hoursTalked;

    public BatteryType Model 
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double? HoursIdle 
    {
        get { return this.hoursIdle; }
        set 
        {
            this.hoursIdle = value; 
            if (value < 0)
            {
                throw new ArgumentException("Hours Idle must be positive number!");
            }
        }
    }

    public double? HoursTalked
    {
        get { return this.hoursTalked; }
        set 
        {
            this.hoursTalked = value; 

            if (value < 0)
            {
                throw new ArgumentException("Hours Talked must be a positive number!");
            }
        }
    }

    public void Print()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Battery Type: " + this.Model);
        Console.WriteLine("Hours Idle: " + this.HoursIdle);
        Console.WriteLine("Hours Talked: " + this.HoursTalked);
        Console.WriteLine("=========================");
    }

    public override string ToString()
    {
        return string.Format("=========================/nBattery Type: {0}/nHours Idle: {1}/nHours Talked: {2}========================="
            , this.model, this.hoursIdle, this.hoursTalked);
        
    }
}