//Write a program to read your birthday from the console and print how old you are now and how old you will be 
//after 10 years.
using System;
class AgeAfter10Y
{
    static void Main()
    {
        Console.Write("Enter your current age - ");
        int age = int.Parse(Console.ReadLine());
        int after10Y = age + 10;
        Console.WriteLine("After 10 years you'll be {0} years old.", after10Y);
    }
}
