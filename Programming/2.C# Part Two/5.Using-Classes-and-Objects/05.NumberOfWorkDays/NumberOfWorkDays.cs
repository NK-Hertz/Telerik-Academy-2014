using System;

/*Write a method that calculates the number of workdays between today and given 
 * date, passed as parameter. Consider that workdays are all days from Monday
 * to Friday except a fixed list of public holidays specified preliminary as
 * array.*/

class NumberOfWorkDays
{
    static void Main()
    {
        Console.WriteLine("Enter end date : YYYY/MM/DD : ");
        string[] endDayArr = Console.ReadLine().Split('/');
        int year = int.Parse(endDayArr[0]);
        int month = int.Parse(endDayArr[1]);
        int day = int.Parse(endDayArr[2]);

        DateTime today = DateTime.Today;
        DateTime selectedDay = new DateTime(year, month, day);
        int daysLenght = (selectedDay - today).Days;

        DateTime[] Holidays = { new DateTime(2013, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 30),
                                   new DateTime(2013, 12, 31), new DateTime(2014, 01, 01), new DateTime(2014, 04, 02) };

        int workDays = 0;
        bool isHoliday = false;

        for (int i = 0; i < daysLenght; i++)
        {
            today = today.AddDays(1);
            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int j = 0; j < Holidays.Length; j++)
                {
                    if (today == Holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDays++;
                }

            }
        }
        Console.WriteLine(workDays);
    }
}