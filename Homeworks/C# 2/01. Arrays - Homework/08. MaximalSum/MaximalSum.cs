//Write a program that finds the sequence of maximal sum in given array.
using System;
class MaximalSum
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
            int max = 0; 
            int sum = 0;
            int end = 0;
            int str = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if(sum > max)
                {
                    max = sum;
                    end = i;
                }
                if(sum <= 0)
                {
                    str++;
                    sum = 0;
                }
            }
            Console.WriteLine("Max = " + max);
            for(int i = str; i <= end; i++)
            {
                if(i != end)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
            Console.WriteLine();
        }
    }


