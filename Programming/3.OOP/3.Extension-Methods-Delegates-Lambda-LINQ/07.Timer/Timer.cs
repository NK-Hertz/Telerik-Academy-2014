using System;
using System.Threading;

public class Timer
{
    public delegate void MethodToExecute();

    public MethodToExecute currentMethods;
    private int interval = 0;
    private int overalTime;

    public int OveralTime
    {
        get
        {
            return this.overalTime;
        }
        set
        {
            this.overalTime = value * 1000;
        }
    }

    public int Interval
    {
        get
        {
            return this.interval;
        }
        set
        {
            this.interval = value;
        }
    }

    public MethodToExecute CurrentMethods
    {
        get
        {
            return this.currentMethods;
        }
        set
        {
            this.currentMethods = value;
        }
    }

    public Timer() : this(0, 20)
    { 
    }

    public Timer(int miliseconds, int TotalSeconds)
    {
        this.OveralTime = TotalSeconds;
        this.interval = miliseconds;
    }

    public void Execute()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddMilliseconds(OveralTime);
        while (start <= end)
        {
            currentMethods();
            Thread.Sleep(Interval);
            start = DateTime.Now;
        }

    }
}