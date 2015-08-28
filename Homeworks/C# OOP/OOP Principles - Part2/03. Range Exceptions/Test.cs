//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering 
//numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
using System;
class Test
{
    static void Main()
    {
        int num = 108;
        if(num < 0 || num > 100)
        {
            throw new InvalidRangeException<int>(0, 100, "The num must be bigger than 0 and smaller than 100");
        }
        else
        {
            Console.WriteLine("Valid number!");
        }

        DateTime date = DateTime.Now;
        if(date < new DateTime(1/1/1980) || date > new DateTime(31/12/2013))
        {
            throw new InvalidRangeException<DateTime>(new DateTime(1/1/1980), new DateTime(31/12/2013), "The Date must be after 01.01.1980 and before 31.12.2013");
        }
        else
        {
            Console.WriteLine("Valid date!");
        }
    }
}