using System;
using System.Text;
//•	Write a program that replaces in a HTML document given as string all the tags
//  <a href="…">…</a> with corresponding tags [URL=…]…/URL].
class ReplaceTags
{
    static void Main()
    {
        Console.Write("Enter HTML document: ");
        string text = Console.ReadLine();
        text = text.Replace("<a href", "[URL");
        text = text.Replace("</a>", "[/URL]");
        StringBuilder textBuild = new StringBuilder(text);
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '>' && text[i - 1] == '"')
            {
                textBuild = textBuild.Remove(i, 1);
                textBuild = textBuild.Insert(i, ']');
            }
        }
            Console.WriteLine(textBuild);
    }
}

