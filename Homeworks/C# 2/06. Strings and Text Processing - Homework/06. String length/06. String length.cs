using System;
/*•	Write a program that reads from the console a string of maximum 20 characters. If the 
        * length of the string is less than 20, the rest of the characters should be filled with *.
         •	Print the result string into the console.*/
class StringLength
{
    static void Main()
    {
        Console.Write("Enter text up to 20 characters(including white spaces): ");
        string text = Console.ReadLine().PadRight(20,'*');
        if(text.Length > 20)
        {
            Console.WriteLine("The text is too long!");
        }
        else
        {
            Console.WriteLine(text);  
        }
    }
}
