//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using 
//some programming logic.
//Print the variable values before and after the exchange.
using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The value of a is {0} \nThe value of b is {1}", a, b);
        int exchange = a;
        a = b;
        b = exchange;
        Console.WriteLine("The value of a after exchange is {0} \nThe value of b after exchange is {1}", a, b);
    }
}

