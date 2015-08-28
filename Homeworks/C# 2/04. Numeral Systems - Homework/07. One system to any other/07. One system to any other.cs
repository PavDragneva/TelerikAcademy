using System;
//•	Write a program to convert from any numeral system of given base s to any other 
//  numeral system of base d (2 ≤s, d ≤ 16).
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("s = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        string num = Console.ReadLine().ToUpper();
        int mul = 1;
        int decNum = 0;
        for (int i = num.Length-1; i >= 0; i--)
        {
            if(num[i] <= '9')
            {
                decNum += (num[i] - '0') * mul;
                mul *= s;
            }
            else
            {
                decNum += (num[i] - '@'+9) * mul;
                mul *= s;
            }
        }
        string result = string.Empty;
        while(decNum > 0)
        {
            if(decNum%d < 9)
            {
                result += decNum % d;
            }
            else
            {
                int temp = decNum % d+55;
                char letter =(char)temp;
                result += letter;
            }
            decNum /= d;
        }
        char[] arr = new char[result.Length];
        for (int i = result.Length-1; i >= 0; i--)
        {
            arr[i] = result[i];
        }
        result = string.Empty;
        for (int i = arr.Length-1; i >= 0; i--)
        {
            result += arr[i];
        }
        Console.WriteLine(result);
    }
}

