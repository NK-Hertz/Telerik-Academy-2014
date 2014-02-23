using System;
/*
 * Using delegates write a class Timer that has can execute certain method at each t seconds.
 */
class TimerExample
{
    public static void Main()
    {
        Timer aTimer = new Timer(1000, 10);
        aTimer.CurrentMethods = TestMetnod;
        aTimer.Execute();
    }

    public static void TestMetnod()
    {
        Console.WriteLine("Message for executing.");
    }
}