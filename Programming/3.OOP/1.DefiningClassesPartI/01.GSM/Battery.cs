using System;
using System.ComponentModel;
using System.Text;

//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
public enum BatteryType
{ 
    LiIon, NiMH,NiCD
}

class Battery
{
    //encapsulation
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

    //print information about Battery Class
    public void Print()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Battery Type: " + this.Model);
        Console.WriteLine("Hours Idle: " + this.HoursIdle);
        Console.WriteLine("Hours Talked: " + this.HoursTalked);
        Console.WriteLine("=========================");
    }

    //Try to override ToString().
    public override string ToString()
    {
        return string.Format("=========================/nBattery Type: {0}/nHours Idle: {1}/nHours Talked: {2}========================="
            , this.model, this.hoursIdle, this.hoursTalked);
        
    }
}