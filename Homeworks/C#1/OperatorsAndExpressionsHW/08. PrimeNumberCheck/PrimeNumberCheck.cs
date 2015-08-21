//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).
using System;
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 0)
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine("The number is prime? - {0}", isPrime);
        }
    }
}


