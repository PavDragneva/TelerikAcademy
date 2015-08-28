using System;
/*•	Write a method GetMax() with two parameters that returns the larger of two integers.
         •	Write a program that reads 3 integers from the console and prints the largest of 
        * them using the method GetMax(). */
class GetLargestNumber
{
    static int GetMax(int num1, int num2)
    {
        int max = 0;
        if(num1 >= num2)
        {
            max = num1;
        }
        else 
        {
            max = num2;
        }
        return max;
    }
    static void Main()
    {
       Console.Write("Enter number1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number2: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter number3: ");
        int num3 = int.Parse(Console.ReadLine());
        int max = GetMax(GetMax(num1, num2),num3);
        Console.WriteLine("The number with max value is {0}.", max);
    }
}

