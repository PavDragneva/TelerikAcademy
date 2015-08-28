using System;
//•	Write a program to convert decimal numbers to their hexadecimal representation.
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        string numHex = string.Empty;
        while(num > 0)
        {
            if(num % 16 < 10)
            {
                numHex += num % 16; 
            }
            else
            {
                int temp = (num % 16)+55;
                char letter = (char)temp;
                numHex += letter;
            }
            num /= 16;
        }
        char[] arr = numHex.ToCharArray();
        numHex = string.Empty;
        for (int i = arr.Length-1; i >= 0; i--)
        {
            numHex += arr[i];
        }
            Console.WriteLine(numHex);
    }
}

