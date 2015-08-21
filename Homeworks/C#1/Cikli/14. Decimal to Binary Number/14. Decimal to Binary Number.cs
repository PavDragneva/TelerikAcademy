using System;

//Problem 14. Decimal to Binary Number
//• Using loops write a program that converts an integer number to its binary
//representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.

//Examples:
//decimal     binary
//0           0 
//3           11 
//43691       1010101010101011 
//236476736   1110000110000101100101000000 

class Decimal_to_Binary_Number
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int decNumber = int.Parse(Console.ReadLine());
        string binNum = "";
        while(decNumber/2 > 0)
        {
            binNum += decNumber % 2;
            decNumber /= 2;
        }
        char[] binArray = binNum.ToCharArray();
        binNum = "";
        for(int i = binArray.Length-1; i >= 0; i--)
        {
            binNum += binArray[i];
        }
        Console.WriteLine((decNumber%2) + binNum);
    }
}
