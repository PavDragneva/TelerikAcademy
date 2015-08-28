using System;
using System.Numerics;
//•	Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
class NFactorial
{
    static void CalculateFactoriel(BigInteger[] arr)
    {
        int index = 0;
        while (index < 99)
        {
            arr[index + 1] *= arr[index];
            index++;
        }
    }
    static void Main()
    {
        BigInteger[] arr = new BigInteger[100];
        for(int i = 0; i < 100; i++)
        {
            arr[i] = i+1;
        }
        CalculateFactoriel(arr);
        foreach(BigInteger nums in arr)
        {
            Console.WriteLine(nums);
        }
    }
}
