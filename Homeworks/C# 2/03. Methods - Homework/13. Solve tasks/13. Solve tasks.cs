using System;
using System.Text;
using System.Linq;
/*•	Write a program that can solve these tasks:
           o	Reverses the digits of a number
           o	Calculates the average of a sequence of integers
           o	Solves a linear equation a * x + b = 0
         •	Create appropriate methods.
         •	Provide a simple text-based menu for the user to choose which task to solve.
         •	Validate the input data:
           o	The decimal number should be non-negative
           o	The sequence should not be empty
           o	a should not be equal to 0*/
class SolveTasks
{
    static decimal Reverse(decimal num)
    {
        string numStr = num.ToString();
        StringBuilder temp = new StringBuilder();
        for (int i = numStr.Length - 1; i >= 0; i--)
        {
            temp.Append(numStr[i]);
        }

        decimal number = decimal.Parse(temp.ToString());
        return number;
    }
    static int Average(int[] arr)
    {
        int sum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        int avg = sum / arr.Length;
        return avg;
    }
    static double SolveEquation(double a, double b)
   {
       double result = -b / a;
       return result;
   }
    static void Main()
    {
        Console.WriteLine(@" Choose an action to perfom and enter his number:

- Reverses the digits of a number - 1;
- Calculates the average of a sequence of integers - 2;
- Solves a linear equation - 3");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            Console.Write("Enter number: ");
            decimal num = decimal.Parse(Console.ReadLine());
            if(num >= 0)
            {
                num = Reverse(num);
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        else if(choice == 2)
        {
            Console.Write("Enter some numbers: ");
            string numStr = Console.ReadLine();
            int[] arr = numStr
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if(arr != null)
            {
                int avg = Average(arr);
                Console.WriteLine(avg);
            }
            else
            {
                Console.WriteLine("Invalid numbers!");
            }
        }
        else if(choice == 3)
        {
            Console.Write("a = ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = int.Parse(Console.ReadLine());
            if(a != 0)
            {
                double result = SolveEquation(a, b);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid number for a!");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}

