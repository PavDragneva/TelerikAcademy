using System;
/*•	Write a method ReadNumber(int start, int end) that enters an integer number in a given 
        * range [start…end].
           o	If an invalid number or non-number text is entered, the method should throw an exception.
         •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 
        * 1 < a1 < … < a10 < 100*/
class EnterNumbers
{
    static int ReadNumber(int start, int end, int counter)
    {
        try
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if(num > end || num < start)
            {
                throw new ArgumentOutOfRangeException();
            }
            start = num;
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid format!");
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        while (counter < 10)
        {
            counter++;
            counter = ReadNumber(start, end, counter);
        }
        return counter;
    }
    static void Main()
    {
        int start = 1;
        int end = 100; 
        int counter = 1;
        ReadNumber(start, end, counter);
    }
}
