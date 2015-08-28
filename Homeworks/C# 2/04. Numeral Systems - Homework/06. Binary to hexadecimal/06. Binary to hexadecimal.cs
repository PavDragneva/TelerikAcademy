using System;
//•	Write a program to convert binary numbers to hexadecimal numbers (directly).
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string num = Console.ReadLine();
        char[] arr = num.ToCharArray();
        int mult = 1;
        int decNumber = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            decNumber += (arr[i] - '0') * mult;
            mult *= 2;
        }
        string numHex = string.Empty;
        while (decNumber > 0)
        {
            if (decNumber % 16 < 10)
            {
                numHex += decNumber % 16;
            }
            else
            {
                int temp = (decNumber % 16) + 55;
                char letter = (char)temp;
                numHex += letter;
            }
            decNumber /= 16;
        }
        char[] arrHex = numHex.ToCharArray();
        numHex = string.Empty;
        for (int i = arrHex.Length - 1; i >= 0; i--)
        {
            numHex += arrHex[i];
        }
        Console.WriteLine(numHex);
    }
}

