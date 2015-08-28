using System;
using System.Threading;
using System.Globalization;
//•	Write a method that reverses the digits of given decimal number.
class ReverseNumber
{
    static decimal numReversed(decimal num)
    {
        string len = num.ToString();
        string temp = string.Empty;
        for(int i = 0; i < len.Length; i++)
        {
            temp += len[len.Length-1-i];
        }
        num = decimal.Parse(temp);
        return num;
    }
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter number: ");
        decimal num = decimal.Parse(Console.ReadLine());
        num = numReversed(num);
        Console.WriteLine(num);
    }
}