using System;
//•	Write a method that counts how many times given number appears in given array.
//•	Write a test program to check if the method is workings correctly.
class AppearanceCount
{
    static int countAppears(int[] arr, int num)
    {
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == num)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        Console.Write("Enter sume numbers: ");
        string nums = Console.ReadLine();
        string[] arrStr = nums.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrStr.Length];
        for(int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }
        Console.Write("Enter number for check: ");
        int num = int.Parse(Console.ReadLine());
        int appearance = countAppears(arr, num);
        Console.WriteLine("The number {0} apearce {1} times in the array.", num, appearance);
    }
}
