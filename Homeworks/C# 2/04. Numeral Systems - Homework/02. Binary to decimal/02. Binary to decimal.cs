using System;
//•	Write a program to convert binary numbers to their decimal representation.
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string num = Console.ReadLine();
        char[] arr = num.ToCharArray();
        int mult = 1;
        int decNumber = 0;
        for(int i = arr.Length-1; i >= 0; i--)
        {
            decNumber += (arr[i] - '0') * mult;
            mult *= 2;
        }
        Console.WriteLine(decNumber);
    }
}

