using System;
//•	Write a method that adds two positive integer numbers represented as arrays of digits 
//  (each array element arr[i]contains a digit; the last digit is kept in arr[0]).
//•	Each of the numbers that will be added could have up to 10 000 digits.
class NumberAsArray
{
    static int[] StringToIntArray(string num)
    {
        int[] arr = new int[num.Length];
        for(int i = 0; i < num.Length; i++)
        {
            arr[i] = num[num.Length - 1 - i]-'0';
        }
        return arr;
    }
    static int[] Adding(int[] arr1, int[] arr2)
    {
    if(arr1.Length > arr2.Length)
    {
        int[] temp = new int[arr1.Length];
        for(int i = 0; i < arr1.Length; i++)
        {
            if(i < arr2.Length)
            {
                temp[i] = arr1[i] + arr2[i];
            }
            else
            {
                temp[i] = arr1[i];
            }
        }
        Array.Reverse(temp);
      return temp;
    }
    else
    {
        int[] temp = new int[arr2.Length];
        for (int i = 0; i < arr2.Length; i++)
        {
            if (i < arr1.Length)
            {
                temp[i] = arr1[i] + arr2[i];
            }
            else
            {
                temp[i] = arr2[i];
            }
        }
      return temp;
    }
    }
    static void Main()
    {
        Console.Write("Write integer: ");
        string num1 = Console.ReadLine();
        int[] arr1 = StringToIntArray(num1);
        Console.Write("Write integer: ");
        string num2 = Console.ReadLine();
        int[] arr2 = StringToIntArray(num2);
        int[] result = Adding(arr1, arr2);
        Console.WriteLine("Result");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

