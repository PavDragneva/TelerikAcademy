//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, 
//average.
using System;
using System.Collections.Generic;
using System.Linq;
class Test
{
    static void Main()
    {
        List<int> some = new List<int> { 1, 3, -7, 1, 10, -9, 2, 9, 22, 4 };
        Console.WriteLine("Sum: " + some.Sum());
        Console.WriteLine("Product: " + some.Product());
        Console.WriteLine("Min: " + some.Min());
        Console.WriteLine("Max: " + some.Max());
        Console.WriteLine("Average: " + some.Average());
    }
}