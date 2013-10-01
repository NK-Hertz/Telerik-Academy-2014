using System;

class Call
{
    private DateTime date;
    private string time;
    private string dialedPhone;
    private uint duration;

    public Call(string dialedPhone, uint duration)
    {
        DateTime date = DateTime.Now;
        string time = date.Hour + ":" + date.Minute + ":" + date.Second;

        this.date = date;
        this.time = time;
        this.dialedPhone = dialedPhone;
        this.duration = duration;
    }

    public uint Duration
    {
        get { return this.duration; }
    }

    public DateTime Date
    {
        get { return this.date; }
    }

    public string DialedPhone
    {
        get { return this.dialedPhone; }
    }

    public string Time
    {
        get { return this.time; }
    }

    public void PrintCall()
    {
        Console.WriteLine("Dialed number: {0}", dialedPhone);
        Console.WriteLine("Duration: {0}",duration);
    }
}