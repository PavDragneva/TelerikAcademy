using System;
//•	Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//•	Use variable number of arguments.
class IntegerCalculations
{
    static int Minimum(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if(min > arr[i])
            {
                min = arr[i];
            }
        }
            return min;
    }
    static int Maximum(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    static int Average(int sum, int[] arr)
    {
        int avg = sum / arr.Length;
        return avg;
    }
    static int Sum(int[] arr)
    {
        int sum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static int Product(int[] arr)
    {
        int product = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
    static void Main()
    {
        Console.Write("Write some numbers: ");
        string numString = Console.ReadLine();
        string[] arrChar = numString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrChar.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(arrChar[i]);
        }
        int max = Maximum(arr);
        int min = Minimum(arr);
        int sum = Sum(arr);
        int avg = Average(sum, arr);
        int product = Product(arr);
        Console.WriteLine("The sum of the numbers is {0} \nThe max number is {1} \nThe min number is {2} \nThe average {3} \nThe product is {4}", sum, max, min, avg, product);
    }
}