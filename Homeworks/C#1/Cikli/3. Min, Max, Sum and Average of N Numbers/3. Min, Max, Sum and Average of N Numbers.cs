using System;

//Problem 3. Min, Max, Sum and Average of N Numbers
//• Write a program that reads from the console a sequence of  n  integer numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
//• The output is like in the examples below.

//Example 1:
//input       output
//3           min = 1 
//2           max = 5 
//5           sum = 8 
//1           avg = 2.67 

//Example 2:
//input       output
//2           min = -1 
//-1          max = 4 
//4           sum = 3 
//            avg = 1.50 

class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i = 0; i<n; i++)
        {
            Console.Write("Enter number №{0}: ", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int min = Math.Max(array[n-1], array[n-2]);  
        int max = 0;
        double sum = 0;
        for(int i = 0; i < n-1; i++)
        {
            int testForMin = Math.Min(array[i], array[i + 1]);
            int testForMax = Math.Max(array[i], array[i +1]);
            if(min>testForMin)
            {
                min = testForMin;
            }
            if(max < testForMax)
            {
                max = testForMax;
            }
            sum+=array[i];
        }
        sum += array[n-1]; 
         double avg = sum/n;
        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:0.00}", min, max,sum,avg);
    }
}

