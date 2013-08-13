using System;

/*Write a method that calculates the number of workdays between today and given 
 * date, passed as parameter. Consider that workdays are all days from Monday
 * to Friday except a fixed list of public holidays specified preliminary as
 * array.*/

class NumberOfWorkDays
{
    static DateTime[] holidays = { new DateTime(2012, 12, 24), new DateTime(2012, 12, 25), new DateTime(2012, 12, 30),
                                   new DateTime(2012, 12, 31), new DateTime(2013, 01, 01) };

    static void Main()
    {
        DateTime today = DateTime.Today;

        //today and a given day
        //workdays - monday - friday
        //fixed list of holidays - as array
    }
}