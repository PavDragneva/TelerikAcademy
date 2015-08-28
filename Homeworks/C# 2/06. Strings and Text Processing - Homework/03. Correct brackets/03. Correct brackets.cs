using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//•	Write a program to check if in a given expression the brackets are put correctly.
class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Write some expression: ");
        string expression = Console.ReadLine();
        List<int> indexOpBrack = new List<int>();
        List<int> indexCloseBrack = new List<int>();
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                indexOpBrack.Add(i);
            }
            if (expression[i] == ')')
            {
                indexCloseBrack.Add(i);
            }
        }
        if(indexOpBrack.Count != indexCloseBrack.Count)
        {
            Console.WriteLine("Brackets are put incorrectly!");
        }
        else
        {
            for(int i = 0; i < indexOpBrack.Count; i++)
            {
                if(indexOpBrack[i] > indexCloseBrack[i])
                {
                    Console.WriteLine("Brackets are put incorrectly!");
                    break;
                }
                else if(i == indexOpBrack.Count-1)
                {
                    Console.WriteLine("Brackets are put correctly!");
                }
            }
        }
    }
}
