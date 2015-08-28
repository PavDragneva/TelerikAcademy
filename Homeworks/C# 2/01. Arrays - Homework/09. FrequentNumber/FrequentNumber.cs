//Write a program that finds the most frequent number in an array.
using System;
class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter some nums: ");
        string nums = Console.ReadLine();
        string[] arrayStr = nums.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[arrayStr.Length];
        for (int i = 0; i < arrayStr.Length; i++)
        {
            array[i] = int.Parse(arrayStr[i]);
        }
        int count = 1;
        int max = 0;
        int num = 0;
        for (int l = 0; l < array.Length-1; l++)
        {
            for (int i = l+1; i < array.Length; i++)
            {
                if(array[l] == array[i])
                {
                    count++;
                }
            }
            if (max < count)
            {
                max = count;
                num = array[l];
            }
            count = 1;
        }
        Console.WriteLine("{0} --> {1} times", num, max);
    }
}

