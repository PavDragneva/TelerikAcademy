using System;
//•	Write a program to convert hexadecimal numbers to their binary representation.
class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexNum = Console.ReadLine().ToUpper();
        int mult = 1;
        int decNum = 0;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            if (hexNum[i] < 58)
            {
                decNum += (hexNum[i] - '0') * mult;
                mult *= 16;
            }
            else
            {
                decNum += (hexNum[i] - 55) * mult;
                mult *= 16;
            }
        }
        string numBin = string.Empty;
        while (decNum > 0)
        {
            numBin += decNum % 2;
            decNum /= 2;
        }
        char[] arr = numBin.ToCharArray();
        numBin = string.Empty;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            numBin += arr[i] - '0';
        }
        Console.WriteLine(numBin);
    }
}

