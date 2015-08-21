using System;
using System.Threading;
using System.Globalization;

//Problem 4. Multiplication Sign
//• Write a program that shows the sign (+, - or 0) of the product of three real numbers,
//without calculating it. ◦ Use a sequence of  if  operators.

//Examples:
//a       b       c       result
//5       2       2       + 
//-2      -2      1       + 
//-2      4       3       - 
//0       -2.5    4       0 
//-1      -0.5    -5.1    - 

class Multiplication_Sign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter value for the first real number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for the second real number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for the third real number: ");
        double c = double.Parse(Console.ReadLine());
        if(a == 0 || b== 0 || c == 0)
        {
            Console.WriteLine("The result is 0.");
        }
        else
        {
            if(a>0)
            {
                if((b>0 && c>0) || (b<0 && c<0))
                {
                    Console.WriteLine("The result is +.");
                }
                else
                {
                    Console.WriteLine("The result is -.");
                }
            }
            else if(b>0)
            {
                if(a<0 && c<0)
                {
                    Console.WriteLine("The result is +.");
                }
                else
                {
                    Console.WriteLine("The result is -.");
                }
            }
            else if(c>0)
            {
                if(a<0 && b<0)
                {
                    Console.WriteLine("The result is +.");
                }
                else
                {
                    Console.WriteLine("The result is -.");
                }
            }
            else
            {
                Console.WriteLine("The result is -.");
            }
        }
    }
}

