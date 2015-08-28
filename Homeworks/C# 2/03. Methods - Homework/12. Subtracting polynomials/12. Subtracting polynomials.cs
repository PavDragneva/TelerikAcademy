using System;
using System.Linq;
//•	Extend the previous program to support also subtraction and multiplication of polynomials.
class SubtractingPolynomials
{
    static void MultipPoly(int[] poly1, int[] poly2)
    {
        Array.Reverse(poly1);
        Array.Reverse(poly2);
        int[] result = new int[poly1.Length + poly2.Length - 1];
        int count = 0;
        for (int i = 0; i < poly1.Length; i++)
        {
            for (int j = 0; j < poly2.Length; j++)
            {
                    result[j + count] += poly1[i] * poly2[j];
            }
            count++;
        }
        Array.Reverse(result);
        Console.WriteLine("RESULT");
        PrintPoly(result);
    }
    static void SubstracPoly(int[] poly1, int[] poly2)
    {
        Array.Reverse(poly1);
        Array.Reverse(poly2);
        if (poly1.Length > poly2.Length)
        {
            int[] result = new int[poly1.Length];
            for (int i = 0; i < poly1.Length; i++)
            {
                if (i < poly2.Length)
                {
                    result[i] = poly1[i] - poly2[i];
                }
                else
                {
                    result[i] = poly1[i];
                }
            }
            Array.Reverse(result);
            Console.WriteLine("RESULT");
            PrintPoly(result);
        }
        else
        {
            int[] result = new int[poly2.Length];
            for (int i = 0; i < poly2.Length; i++)
            {
                if (i < poly1.Length)
                {
                    result[i] = poly1[i] - poly2[i];
                }
                else
                {
                    result[i] = -poly2[i];
                }
            }
            Array.Reverse(result);
            Console.WriteLine("RESULT");
            PrintPoly(result);
        }
    }
    static void AddsPoly(int[] poly1, int[] poly2)
    {
        Array.Reverse(poly1);
        Array.Reverse(poly2);
        if (poly1.Length > poly2.Length)
        {
            int[] result = new int[poly1.Length];
            for (int i = 0; i < poly1.Length; i++)
            {
                if (i < poly2.Length)
                {
                    result[i] = poly1[i] + poly2[i];
                }
                else
                {
                    result[i] = poly1[i];
                }
            }
            Array.Reverse(result);
            Console.WriteLine("RESULT");
            PrintPoly(result);
        }
        else
        {
            int[] result = new int[poly2.Length];
            for (int i = 0; i < poly2.Length; i++)
            {
                if (i < poly1.Length)
                {
                    result[i] = poly1[i] + poly2[i];
                }
                else
                {
                    result[i] = poly2[i];
                }
            }
            Array.Reverse(result);
            Console.WriteLine("RESULT");
            PrintPoly(result);
        }
    }
    static void PrintPoly(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                Console.Write("{0}", arr[i]);
            }
            else
            {
                Console.Write("{0}x ^ {1} + ", arr[i], arr.Length - i - 1);
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Enter coefficients for the first polynomial: ");
        string coef1 = Console.ReadLine();
        Console.WriteLine("Enter coefficients for the second polynomial: ");
        string coef2 = Console.ReadLine();
        int[] arrPoly1 = coef1
                             .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();
        int[] arrPoly2 = coef2
                             .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();
        PrintPoly(arrPoly1);
        PrintPoly(arrPoly2);
        Console.WriteLine(@"Choose action(1-3):
        1. Adding polynomials;
        2. Substracting polynomials;
        3. Multiplication of polynomials;");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            AddsPoly(arrPoly1, arrPoly2);
        }
        else if (choice == 2)
        {
            SubstracPoly(arrPoly1, arrPoly2);
        }
        else if (choice == 3)
        {
            MultipPoly(arrPoly1, arrPoly2);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}
