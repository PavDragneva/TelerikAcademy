using System;
using System.Linq;
//•	Write a program to convert decimal numbers to their binary representation.
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        string numBin = string.Empty;
        while(num > 0)
        {
            numBin += num % 2;
            num /= 2;
        }
        char[] arr = numBin.ToCharArray();
        numBin = string.Empty;
        for (int i = arr.Length-1; i >= 0; i--)
        {
            numBin += arr[i] - '0';
        }
            Console.WriteLine(numBin);
    }
}
