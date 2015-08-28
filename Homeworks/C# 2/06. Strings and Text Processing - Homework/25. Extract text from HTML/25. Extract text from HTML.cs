using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
//•	Write a program that extracts from given HTML file its title (if available), 
//  and its body text without the HTML tags.
class ExtractTextFromHTML
{
    static void Main()
    {
        string fileHTML = @"<html><head><title>News</title></head>
  <body><p><a href=''/http://academy.telerik.com''>Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        string head = string.Empty;
        if(fileHTML.Contains("<title>"))
        {
            int index = fileHTML.IndexOf("<title>");
            int endIndex = fileHTML.IndexOf("</title>");
            head = fileHTML.Substring(index + 7, endIndex - (index + 7));
        }
        StringBuilder newString = new StringBuilder();
        if (fileHTML.Contains("<body>"))
        {
            int index = fileHTML.IndexOf("<body>");
            int endIndex = fileHTML.IndexOf("</body>");
            newString.Append(fileHTML.Substring(index + 6, endIndex - (index + 6)));
        }
        fileHTML = newString.ToString();
        List<int> opBrack = new List<int>();
        List<int> clBrack = new List<int>();
        int startIndex = 0;
        while (true)
        {
            int found = fileHTML.IndexOf('<', startIndex);
            if (found < 0)
            {
                break;
            }
            opBrack.Add(found);
            startIndex = found + 1;
        }
        startIndex = 0;
        while (true)
        {
            int found = fileHTML.IndexOf('>', startIndex);
            if (found < 0)
            {
                break;
            }
            clBrack.Add(found);
            startIndex = found + 1;
        }
        StringBuilder textSB = new StringBuilder();
        for (int i = 0; i < opBrack.Count-1; i++)
        {
            textSB.Append(fileHTML.Substring(clBrack[i], opBrack[i+1] - clBrack[i]));
        }
        textSB.Replace(">", " ");
        string text = textSB.ToString();
            if (head != null)
            {
                Console.WriteLine("Title: {0}", head);
            }
        Console.WriteLine("Text: {0}", text.Trim());
    }
}

