using System;
using System.Globalization;
//•	Write a program that reads two dates in the format:
//  day.month.year and calculates the number of days between them.
class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        string date1 = Console.ReadLine();
        DateTime dateFirst = DateTime.ParseExact(date1, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter second date: ");
        string date2 = Console.ReadLine();
        DateTime dateSecond = DateTime.ParseExact(date2, "d.MM.yyyy", CultureInfo.InvariantCulture);
        int days = (dateSecond - dateFirst).Days;
        Console.WriteLine(days);
    }
}

