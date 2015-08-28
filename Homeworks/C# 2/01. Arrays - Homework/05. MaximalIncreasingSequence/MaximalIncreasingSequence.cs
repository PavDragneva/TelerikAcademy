//Write a program that finds the maximal increasing sequence in an array.
using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter some nums: ");
        string nums = Console.ReadLine();
        string[] arrayStr = nums.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[arrayStr.Length];
        for(int i = 0; i < arrayStr.Length; i++)
        {
            array[i] = int.Parse(arrayStr[i]);
        }
        int maxProgrss = 0;
        int count = 1;
        int end = 0;
        for(int i = 1; i < array.Length; i++)
        {
            if(array[i] == array[i-1]+1)
            {
                count++;
                if((i == array.Length-1)&&(count>maxProgrss))
                {
                    maxProgrss = count;
                    end = i;
                }
            }
            else
            {
                if(maxProgrss < count)
                {
                    maxProgrss = count;
                    end = i-1;
                }
                count = 1;
            }
        }
        for(int i = end - (maxProgrss-1); i <= end; i++)
        {
            if (i == end)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.WriteLine();
    }
}

