using System;
using System.Collections.Generic;

class GSMExample
{
    static void Main()
    {
        GSM firstGSM = new GSM();
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

        GSM[] myGSM = new GSM[3];

        myGSM[0] = new GSM("Galaxy S2", "Samsung", 750, "Nikolai");
        myGSM[1] = new GSM("3110", "Nokia", 10, "Nikolai");
        myGSM[2] = new GSM("N70", "Nokia", 300, "Nikolai");

        for (int i = 0; i < myGSM.Length; i++)
        {
            myGSM[i].Print();
        }

        Console.WriteLine();

        GSM.IPhone4S.Print();
        
        GSM lastGSM = new GSM("Xperia", "Nokia", 800, "Pesho");

        double pricePerMin = 0.37;

        lastGSM.AddCall("08955454521", 300);
        lastGSM.AddCall("25665663663", 165);
        lastGSM.AddCall("252689657954", 214);

        List<Call> history = lastGSM.CallHistory;

        foreach (var call in history)
        {
            call.PrintCall();
            Console.WriteLine();
        }

        Console.WriteLine("The price for the calls is : {0}", lastGSM.CalcPrice(pricePerMin));


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

        lastGSM.DeleteCall(maxDurationIndex);
        Console.WriteLine("The price for the calls is : {0}", lastGSM.CalcPrice(pricePerMin));

        lastGSM.ClearHistory();

        foreach (var call in history)
        {
            call.PrintCall();
            Console.WriteLine();
        }

    }
}