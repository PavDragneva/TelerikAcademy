using System;

//Problem 16. Decimal to Hexadecimal Number
//• Using loops write a program that converts an integer number to its
//hexadecimal representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.

//Examples:
//decimal         hexadecimal
//254             FE 
//6883            1AE3 
//338583669684    4ED528CBB4 

class Decimal_to_Hexadecimal_Number
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        string hexNum = "";
        while(n%16 > 0)
        {
            long num = n % 16;
            string hex = "";
            switch(num)
            {
                case 0: hex = "0"; break;
                case 1: hex = "1"; break;
                case 2: hex = "2"; break;
                case 3: hex = "3"; break;
                case 4: hex = "4"; break;
                case 5: hex = "5"; break;
                case 6: hex = "6"; break;
                case 7: hex = "7"; break;
                case 8: hex = "8"; break;
                case 9: hex = "9"; break;
                case 10: hex = "A"; break;
                case 11: hex = "B"; break;
                case 12: hex = "C"; break;
                case 13: hex = "D"; break;
                case 14: hex = "E"; break;
                case 15: hex = "F"; break;
            }
            hexNum += hex;
            n /= 16;
        }
        //Creating array so I can reverse the hexNum and recieve the hexadecimal value of N.
        char[] hexArray = hexNum.ToCharArray();
        hexNum = ""; 
        for(int i = hexArray.Length-1; i >= 0; i--)
        {
            hexNum += hexArray[i];
        }
        Console.WriteLine(hexNum);
    }
}
