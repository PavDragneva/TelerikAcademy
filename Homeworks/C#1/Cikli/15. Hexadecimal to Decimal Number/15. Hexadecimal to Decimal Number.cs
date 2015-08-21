using System;

//Problem 15. Hexadecimal to Decimal Number
//• Using loops write a program that converts a hexadecimal integer number
//to its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.

//Examples:
//hexadecimal         decimal
//FE                  254 
//1AE3                6883 
//4ED528CBB4          338583669684 

class Hexadecimal_to_Decimal_Number
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexNum = Console.ReadLine().ToUpper();
        char[] hexArray = hexNum.ToCharArray();
        long decNum = 0;
        int power = 16;
        for (int i = 0; i < hexArray.Length; i++)
        {
            if (i > 0)
            {
                switch (hexArray[hexArray.Length - (1+i)])
                {
                    case '0': decNum += (0 * power); break;
                    case '1': decNum += (1 * power); break;
                    case '2': decNum += (2 * power); break;
                    case '3': decNum += (3 * power); break;
                    case '4': decNum += (4 * power); break;
                    case '5': decNum += (5 * power); break;
                    case '6': decNum += (6 * power); break;
                    case '7': decNum += (7 * power); break;
                    case '8': decNum += (8 * power); break;
                    case '9': decNum += (9 * power); break;
                    case 'A': decNum += (10 * power); break;
                    case 'B': decNum += (11 * power); break;
                    case 'C': decNum += (12 * power); break;
                    case 'D': decNum += (13 * power); break;
                    case 'E': decNum += (14 * power); break;
                    case 'F': decNum += (15 * power); break;
                    default: Console.WriteLine("Invalid number!"); break;
                }
                power *= 16;
            }
            else
            {
                switch (hexArray[hexArray.Length-1])
                {
                    case '0': decNum += 0; break;
                    case '1': decNum += 1; break;
                    case '2': decNum += 2; break;
                    case '3': decNum += 3; break;
                    case '4': decNum += 4; break;
                    case '5': decNum += 5; break;
                    case '6': decNum += 6; break;
                    case '7': decNum += 7; break;
                    case '8': decNum += 8; break;
                    case '9': decNum += 9; break;
                    case 'A': decNum += 10; break;
                    case 'B': decNum += 11; break;
                    case 'C': decNum += 12; break;
                    case 'D': decNum += 13; break;
                    case 'E': decNum += 14; break;
                    case 'F': decNum += 15; break;
                    default: Console.WriteLine("Invalid number!"); break;
                }
            }
        }
        Console.WriteLine(decNum);
    }
}
