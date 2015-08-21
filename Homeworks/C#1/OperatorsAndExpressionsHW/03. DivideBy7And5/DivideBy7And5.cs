//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 
//7 and 5 at the same time.
using System;
class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 5 == 0 && number % 7 == 0 ? true : false);
        }
    }

