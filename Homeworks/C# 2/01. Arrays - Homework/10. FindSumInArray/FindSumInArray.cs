//Write a program that finds in given array of integers a sequence of given sum S (if present)
using System;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("s = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter some nums: ");
        string nums = Console.ReadLine();
        string[] arrayStr = nums.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[arrayStr.Length];
        for (int i = 0; i < arrayStr.Length; i++)
        {
            array[i] = int.Parse(arrayStr[i]);
        }
        int sum = 0;
        int leng = 0;
        int count = 1;
        int str = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int l = i; l < array.Length; l++)
            {
                sum += array[l];
                count++;
                if(sum > s)
                {
                    break;
                }
                else if(sum == s)
                {
                    leng = count;
                    str = i;
                    count = 1;
                }
            }
            count = 1;
            sum = 0;
        }
        for (int i = str; i < str+leng-1; i++)
        {
            if (i == str + leng - 2)
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

