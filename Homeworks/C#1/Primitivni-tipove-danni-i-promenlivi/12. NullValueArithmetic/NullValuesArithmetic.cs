//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Null value of int - {0}", nullInt);
        Console.WriteLine("Null value of double - {0}", nullDouble);
        nullInt += 1;
        nullDouble += 1;
        Console.WriteLine("Add 1 to null value of int - {0}", nullInt);
        Console.WriteLine("Add 1 to null value of double - {0}", nullDouble);
        nullInt = 24;
        nullDouble = 50;
        Console.WriteLine("NullInt with new value - {0}", nullInt);
        Console.WriteLine("NullDouble with new value - {0}", nullDouble);
    }
}

