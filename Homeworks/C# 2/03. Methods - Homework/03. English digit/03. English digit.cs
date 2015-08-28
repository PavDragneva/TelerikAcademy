using System;
//•	Write a method that returns the last digit of given integer as an English word.
class EnglishDigit
{
    static string digitAsWord(int digit)
    {
        string digitWord = string.Empty;
        switch(digit)
        {
            case 0: digitWord = "null"; break;
            case 1: digitWord = "one"; break;
            case 2: digitWord = "two"; break;
            case 3: digitWord = "three"; break;
            case 4: digitWord = "four"; break;
            case 5: digitWord = "five"; break;
            case 6: digitWord = "six"; break;
            case 7: digitWord = "seven"; break;
            case 8: digitWord = "eight"; break;
            case 9: digitWord = "nine"; break;
        }
        return digitWord;
    }
    static void Main()
    {
        Console.Write("Enter integer: ");
        int num = int.Parse(Console.ReadLine());
        int digit = num % 10;
        Console.WriteLine(digitAsWord(digit));
    }
}

