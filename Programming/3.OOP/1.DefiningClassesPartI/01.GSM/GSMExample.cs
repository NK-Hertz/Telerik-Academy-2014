using System;
using System.Collections.Generic;

class GSMExample
{
    static void Main()
    {
        GSM firstGSM = new GSM();

        // USER INPUT

        //Console.WriteLine("Enter phone model: ");
        //firstGSM.Model = Console.ReadLine();
        //Console.WriteLine("Enter manufacturer: ");
        //firstGSM.Manufacturer = Console.ReadLine();
        //Console.WriteLine("Enter price: ");
        //firstGSM.Price = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter owner: ");
        //firstGSM.Owner = Console.ReadLine();

        //Console.WriteLine("Enter battery model between Li-Ion,NiMH,NiCD(0-2): ");
        //firstGSM.Battery.Model = (BatteryType)int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter hours idle: ");
        //firstGSM.Battery.HoursIdle = double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter hours talked: ");
        //firstGSM.Battery.HoursTalked = double.Parse(Console.ReadLine());

        //Console.WriteLine("Enter display size: ");
        //firstGSM.Display.Size = uint.Parse(Console.ReadLine());
        //Console.WriteLine("Enter display colours: ");
        //firstGSM.Display.Colours = uint.Parse(Console.ReadLine());

        //AUTO INPUT

        firstGSM.Model = "Galaxy S";
        firstGSM.Manufacturer = "Samsung";
        firstGSM.Price = 899;
        firstGSM.Owner = "The Owner";
        firstGSM.Battery.Model = BatteryType.NiCD;
        firstGSM.Battery.HoursIdle = 216.5;
        firstGSM.Battery.HoursTalked = 15.5;
        firstGSM.Display.Size = 11;
        firstGSM.Display.Colours = 65356;
        
        firstGSM.Print();
        firstGSM.Battery.Print();
        firstGSM.Display.Print();

        GSM newGSM = new GSM("IPhone","Apple");

        newGSM.Print();
        newGSM.Battery.Print();
        newGSM.Display.Print();

        GSM thirdGSM = new GSM("Phone", "Manufact", 106, "Over");
        thirdGSM.Print();


        //Create an array of few instances of the GSM class
        GSM[] myGSM = new GSM[3];

        myGSM[0] = new GSM("Galaxy S2", "Samsung", 750, "Nikolai");
        myGSM[1] = new GSM("3110", "Nokia", 10, "Nikolai");
        myGSM[2] = new GSM("N70", "Nokia", 300, "Nikolai");

        //Display the information about the GSMs in the array
        for (int i = 0; i < myGSM.Length; i++)
        {
            myGSM[i].Print();
        }
        Console.WriteLine();

        //Display the information about the static property IPhone4S.
        GSM.IPhone4S.Print();
        
        //Assume the price per minute is fixed and is provided as a parameter.
        //Assuming that the price per minute is 0.37
        double pricePerMin = 0.37;

        //Create an instance of the GSM class.
        GSM lastGSM = new GSM("Xperia", "Nokia", 800, "Pesho");

        //Add few calls.
        lastGSM.AddCall("08955454521", 300);
        lastGSM.AddCall("25665663663", 165);
        lastGSM.AddCall("252689657954", 214);

        List<Call> history = lastGSM.CallHistory;

        //Display the information about the calls.
        foreach (var call in history)
        {
            call.PrintCall();
            Console.WriteLine();
        }

        //Calculate and print the total price of the calls in the history.
        Console.WriteLine("The price for the calls is : {0}", lastGSM.CalcPrice(pricePerMin));

        //Select the longest call
        int maxDurationIndex = 0;
        uint maxDuration = 0;
        for (int i = 0; i < history.Count; i++)
        {
            if (history[i].Duration > maxDuration)
            {
                maxDurationIndex = i;
                maxDuration = history[i].Duration;
            }
        }

        //Remove the longest call from the history 
        lastGSM.DeleteCall(maxDurationIndex);

        //Calculate the total price again.
        Console.WriteLine("The price for the calls is : {0}", lastGSM.CalcPrice(pricePerMin));

        //Finally clear the call history 
        lastGSM.ClearHistory();

        //and print it.
        foreach (var call in history)
        {
            call.PrintCall();
            Console.WriteLine();
        }

    }
}