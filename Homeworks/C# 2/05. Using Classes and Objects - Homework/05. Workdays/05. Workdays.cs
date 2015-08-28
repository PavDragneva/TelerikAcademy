using System;
/*•	Write a method that calculates the number of workdays between today and given date, 
       * passed as parameter.
        •	Consider that workdays are all days from Monday to Friday except a fixed list of public 
       * holidays specified preliminary as array.*/
class Workdays
{
    static int Weekdays(DateTime now, DateTime future)
    {
        int weekDays = 0;
        DateTime temp = now;
        while (future.AddDays(1) >= temp)
        {
            if (temp.DayOfWeek == DayOfWeek.Saturday || temp.DayOfWeek == DayOfWeek.Sunday)
            {
                weekDays++;
            }
            temp = temp.AddDays(1);
        }
        return weekDays;
    }
    static int Holidays(DateTime now, DateTime future, int days)
    {
        DateTime[] holidays = new DateTime[] { new DateTime(2015, 03, 02), new DateTime(2015, 03, 03), 
        new DateTime(2015, 04, 10), new DateTime(2015, 04, 11), new DateTime(2015, 04, 12), 
        new DateTime(2015, 04, 13), new DateTime(2015, 05, 01), new DateTime(2015, 05, 06), 
        new DateTime(2015, 09, 21), new DateTime(2015, 09, 22), new DateTime(2015, 12, 24), 
        new DateTime(2015, 12, 25), new DateTime(2015, 12, 26), new DateTime(2015, 12, 31)};
        int holyDays = 0;
        for (int i = 0; i < days + 2; i++)
        {
            for (int j = 0; j < holidays.Length; j++)
            {
                if (now.Date == holidays[j].Date && now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday)
                {
                    holyDays++;
                }
            }
            now = now.AddDays(1);
        }
        return holyDays;
    }
    static void Main()
    {
        Console.Write("Enter date in future: ");
        DateTime future = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        TimeSpan span = future - now;
        int days = span.Days;
        int weekDays = Weekdays(now, future);
        int holyDays = Holidays(now, future, days);
        days = days + 2 - holyDays - weekDays;
        Console.WriteLine(days);
    }
}