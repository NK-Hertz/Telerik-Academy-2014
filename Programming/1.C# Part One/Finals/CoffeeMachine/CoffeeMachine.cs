using System;
using System.Threading;
using System.Globalization;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        int N3 = int.Parse(Console.ReadLine());
        int N4 = int.Parse(Console.ReadLine());
        int N5 = int.Parse(Console.ReadLine());
        double inputMoney = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double change = (double)(N1 * 0.05) + (N2 * 0.10) + (N3 * 0.20) + (N4 * 0.50) + (N5 * 1.00);
        double totalMoney = (double)(N1 * 0.05) + (N2 * 0.10) + (N3 * 0.20) + (N4 * 0.50) + (N5 * 1.00) + inputMoney;
        bool moneyCheck = totalMoney - inputMoney >= 0; 
        double moneyLeft = (inputMoney - price - change)*(-1);
        double moreMoney = price - inputMoney;
        double insuffMoney = inputMoney- price - change;
        if (inputMoney >= price && moneyCheck && insuffMoney < 0)
        {
            Console.WriteLine("Yes {0:0.00}", moneyLeft);
        }
        else if (inputMoney < price)
        {
            Console.WriteLine("More {0:0.00}", moreMoney);
        }
        else if (inputMoney >= price && insuffMoney > 0)
        {
            Console.WriteLine("No {0:0.00}", insuffMoney);
        }
    }
}