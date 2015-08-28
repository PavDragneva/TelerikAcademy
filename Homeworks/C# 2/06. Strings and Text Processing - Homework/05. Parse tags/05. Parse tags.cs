using System;
using System.Collections.Generic;
using System.Text;
//•	You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> 
//and</upcase> to upper-case.
//•	The tags cannot be nested.
class ParseTags
{
    static void Main()
    {
      string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
      //Console.WriteLine("Input - {0}", text);
      List<int> openTags = new List<int>();
      List<int> closeTags = new List<int>();
        int indStr = 0;
        int indClose = 0;
      while(true)
      {
          int found = text.IndexOf("<upcase>", indStr);
          if(found < 0)
          {
              break;
          }
          openTags.Add(found);
          indStr = found + 1;
      }
      while (true)
      {
          int found = text.IndexOf("</upcase>", indClose);
          if (found < 0)
          {
              break;
          }
          closeTags.Add(found);
          indClose = found + 1;
      }
      StringBuilder newText = new StringBuilder();
        int index = 0;
      for (int i = 0; i < openTags.Count; i++)
      {
          while(index < openTags[0] || index > closeTags[closeTags.Count-1]||(i != 0 && i != closeTags.Count && index < openTags[i] && index > closeTags[i-1]))
          {
              newText.Append(text[index]);
              index++;
          }
          newText.Append(text.Substring(openTags[i] + 8, closeTags[i] - openTags[i] - 8).ToUpper());
          index = closeTags[i] + 9;
          if(i == openTags.Count-1)
          {
              while(index < text.Length)
              {
                  newText.Append(text[index]);
                  index++;
              }
          }
      }
        Console.WriteLine(newText);
    }
}

