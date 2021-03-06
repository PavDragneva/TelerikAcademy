﻿//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.
using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        if (number / 100 == 0)
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            int fourthDigit = number % 10;
            number /= 10;
            int thirdDigit = number % 10;
            number /= 10;
            int secondDigit = number % 10;
            number /= 10;
            int firstDigit = number % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("The sum of the digits is  - {0}", sum);
            Console.WriteLine("The number in reversed order is " + fourthDigit + thirdDigit + secondDigit + firstDigit);
            Console.WriteLine("When we put the last digit in the first position - " + fourthDigit + firstDigit + secondDigit + thirdDigit);
            Console.WriteLine("When we exchange the second and the third digits - " + firstDigit + thirdDigit + secondDigit + fourthDigit);
        }
    }
}
