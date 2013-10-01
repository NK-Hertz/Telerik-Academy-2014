using System;

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

        //Console.WriteLine("Enter battery model: ");
        //firstGSM.Battery.Model = Console.ReadLine();
        //Console.WriteLine("Enter hours idle: ");
        //firstGSM.Battery.HoursIdle = double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter hours talked: ");
        //firstGSM.Battery.HoursTalked = double.Parse(Console.ReadLine());

        //Console.WriteLine("Enter display size: ");
        //firstGSM.Display.Size = uint.Parse(Console.ReadLine());
        //Console.WriteLine("Enter display colours: ");
        //firstGSM.Display.Colours = Console.ReadLine();

        firstGSM.Model = "Galaxy S";
        firstGSM.Manufacturer = "Samsung";
        firstGSM.Price = 899;
        firstGSM.Owner = "The Owner";
        firstGSM.Battery.Model = "LiIon";
        firstGSM.Battery.HoursIdle = 216.5;
        firstGSM.Battery.HoursTalked = 15.5;
        firstGSM.Display.Size = 11;
        firstGSM.Display.Colours = "16M";
        
        firstGSM.Print();
        firstGSM.Battery.Print();
        firstGSM.Display.Print();

        GSM newGSM = new GSM("IPhone","Apple");

        newGSM.Print();
        newGSM.Battery.Print();
        newGSM.Display.Print();

        GSM thirdGSM = new GSM("Phone", "Manufact", 106, "Over");
        thirdGSM.Print();
    }
}