//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.
using System;
using System.Text;
using System.Linq;
class Test
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Implement an extension method Substring(int index, int length) for the class StringBuilder");
        StringBuilder result = sb.Substring(30, 9);
        Console.WriteLine(result);
    }
}