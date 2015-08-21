using System;

//Problem 11. Random Numbers in Given Range
//• Write a program that enters  3  integers  n ,  min  and  max 
//( min != max ) and prints  n  random numbers in the range  [min...max] .

//Examples:
//n       min         max         random numbers
//5       0           1           1 0 0 1 1 
//10      10          15          12 14 12 15 10 12 14 13 13 11 

//Note: The above output is just an example. Due to randomness, your program most 
//probably will produce different results.

class Random_Numbers_in_Given_Range
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int randoms = 0;
        if (min > max || min == max)
        {
            Console.WriteLine("Invalid numbers!");
        }
        else
        {
            while (n > randoms)
            {
                Console.Write(rnd.Next(min, max+1) + " ");
                randoms++;
            }
        }
    }
}
