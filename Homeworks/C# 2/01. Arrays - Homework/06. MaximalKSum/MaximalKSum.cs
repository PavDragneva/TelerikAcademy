//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;
class MaximalKSum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter value for element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxsum = 0;
        Array.Sort(array);
        for(int i = n-1; i >= n-k; i--)
        {
                maxsum += array[i];
        }
        Console.WriteLine("The max sum is {0} and it's sum of: ", maxsum);
        for (int i = n - 1; i >= n-k; i--)
        {
            Console.Write(array[i] + " ");
        }
    }
}

