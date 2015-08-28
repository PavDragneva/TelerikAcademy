using System;
/*•	Write a program that reads an integer number and calculates and prints its square root.
           o	If the number is invalid or negative, print Invalid number.
           o	In all cases finally print Good bye.
         •	Use try-catch-finally block.*/
class SquareRoot
{
    static void Main()
    {
        try
        {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        if(num < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        double sqrtNum = Math.Sqrt(num);
        Console.WriteLine(sqrtNum);
        }
        catch(FormatException)
        {
            
            Console.WriteLine("Invalid number");
        }
          catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
            {
                Console.WriteLine("Good bye.");
            }
    }
}

