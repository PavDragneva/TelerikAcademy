using System;

//Problem 17.* Calculate GCD
//• Write a program that calculates the greatest common divisor (GCD)
//of given two integers  a  and  b .
//• Use the Euclidean algorithm (find it in Internet).

//Examples:
//a       b       GCD(a, b)
//3       2       1 
//60      40      20 
//5       -15     5 

class Calculate_GCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if(a < b)
        {
            int mask = a;
            a = b;
            b = mask;
        }
        int GCD = 0;
        if(b == 0)
        {
            Console.WriteLine("GCD = {0}", a);
        }
        else
        {
            int dividend = a;
            int divider = b;
            while((dividend%divider) > 0)
            {
                int mask = dividend;
                dividend = divider;
                divider = mask%divider;
                GCD = divider;
            }
        }
        Console.WriteLine("GCD = {0}", GCD);
    }
}
