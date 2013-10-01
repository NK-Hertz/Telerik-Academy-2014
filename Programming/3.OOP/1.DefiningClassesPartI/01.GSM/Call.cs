using System;

//Create a class Call to hold a call performed through a GSM. It should contain date, time, 
//dialed phone number and duration (in seconds).

class Call
{
    //encapsulation
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

    //print information for Calls class
    public void PrintCall()
    {
        Console.WriteLine("Dialed number: {0}", dialedPhone);
        Console.WriteLine("Duration: {0}",duration);
    }
}