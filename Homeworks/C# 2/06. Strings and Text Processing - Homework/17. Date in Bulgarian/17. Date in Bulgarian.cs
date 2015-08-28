using System;
using System.Threading;
using System.Globalization;
/*•	Write a program that reads a date and time given in the format:
        * day.month.year hour:minute:second and prints the date and time 
        * after 6 hours and 30 minutes (in the same format) along with the 
        * day of week in Bulgarian.*/
class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter date: ");
        string dateStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6);
        date = date.AddMinutes(30);
        Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss}", date);
        var culture = new CultureInfo("bg-BG");
        var dayOfWeek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        Console.WriteLine(dayOfWeek);
    }
}
