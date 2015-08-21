using System;

//Problem 11.* Number as Words
//• Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//Examples:
//numbers         number as words
//0               Zero 
//9               Nine 
//10              Ten 
//12              Twelve 
//19              Nineteen 
//25              Twenty five 
//98              Ninety eight 
//98              Ninety eight 
//273             Two hundred and seventy three 
//400             Four hundred 
//501             Five hundred and one 
//617             Six hundred and seventeen 
//711             Seven hundred and eleven 
//999             Nine hundred and ninety nine 

class Number_as_Words
{
    static string nameNumber(int num)
    {
        string numName = " ";
        switch (num)
        {
            case 1: numName = "one"; break;
            case 2: numName = "two"; break;
            case 3: numName = "three"; break;
            case 4: numName = "four"; break;
            case 5: numName = "five"; break;
            case 6: numName = "six"; break;
            case 7: numName = "seven"; break;
            case 8: numName = "eight"; break;
            case 9: numName = "nine"; break;
            case 10: numName = "ten"; break;
            case 11: numName = "eleven"; break;
            case 12: numName = "twelve"; break;
            case 13: numName = "thirteen"; break;
            case 20: numName = "twenty"; break;
            case 30: numName = "thirty"; break;
            case 40: numName = "fourty"; break;
            case 50: numName = "fifty"; break;
            case 60: numName = "sixty"; break;
            case 70: numName = "seventy"; break;
            case 80: numName = "eighty"; break;
            case 90: numName = "ninety"; break;
        }
        return numName;
    }
    static void Main()
    {
        Console.Write("Enter number(0 - 999): ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0 || number > 999)
        {
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        else
        {
            if (number >= 100)
            {
                int hundreds = number / 100;
                if (number % 100 == 0)
                {
                    Console.WriteLine(nameNumber(hundreds) + " hundred");
                }
                else
                {
                    Console.Write(nameNumber(hundreds) + " hundred and ");
                }
            }
            number %= 100;
            if (number <= 13)
            {
                Console.WriteLine(nameNumber(number));
            }
            else if (number > 13)
            {
                if (number < 20)
                {
                    Console.WriteLine(nameNumber(number % 10) + "teen");
                }
                else
                {
                    int digit = number % 10;
                    Console.WriteLine(nameNumber(number - digit) + " " + nameNumber(digit));
                }
            }
        }
    }
}




