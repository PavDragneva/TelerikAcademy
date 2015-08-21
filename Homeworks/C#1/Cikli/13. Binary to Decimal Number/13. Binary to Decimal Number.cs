using System;

//Problem 13. Binary to Decimal Number
//• Using loops write a program that converts a binary integer number to
//its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.

//Examples:
//binary                          decimal
//0                               0 
//11                              3 
//1010101010101011                43691 
//1110000110000101100101000000    236476736 

class Binary_to_Decimal_Number
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binNumber = Console.ReadLine();
        char[] binArray = binNumber.ToCharArray();
        int[] binArrayInt = new int[binArray.Length];
        for(int i = 0; i < binArray.Length; i++)
        {
            binArrayInt[i] = binArray[i] - '0';
        }
        int sum = 0;
        int power = 2;
        for(int i = 0; i <= binArray.Length-2; i++)
        {
            sum += (binArrayInt[binArrayInt.Length - (i + 2)] * power);
            power *= 2;
        }
        Console.WriteLine(sum + binArrayInt[binArrayInt.Length-1]);
    }
}
