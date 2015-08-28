using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
/*•	Write a program that extracts from a given text all dates that match the 
 * format DD.MM.YYYY.
  •	Display them in the standard date format for Canada.*/
    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            foreach (Match date in Regex.Matches(text, @"[0-9]{2}.[0-9]{2}.[0-9]{4}"))
            {
                string[] newDate = date.Value.Split('.');
                var dateTwo = new DateTime(Convert.ToInt32(newDate[2]), Convert.ToInt32(newDate[1]), Convert.ToInt32(newDate[0]));
                Console.WriteLine(dateTwo.ToString("yyyy-MM-dd"));
            }
        }
    }

