using System;
//•	Write a program that reads a year from the console and checks whether it is a leap one.
//•	Use System.DateTime.
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        int daysMonth = DateTime.DaysInMonth(year, 2);
        if(daysMonth > 28)
        {
            Console.WriteLine("The year is leap.");
        }
        else
        {
            Console.WriteLine("The year is NOT leap.");
        }
    }
}

