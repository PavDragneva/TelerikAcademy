using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
/*•	Write a program that reads a list of words from the file words.txt and finds how
        *  many times each of the words is contained in another file test.txt.
         •	The result should be written in the file result.txt and the words should be 
        *  sorted by the number of their occurrences in descending order.
         •	Handle all possible exceptions in your methods.*/
class CountWords
{
    static void Main()
    {
       try
       {
           Console.Write("Enter path to words.txt: ");
           StreamReader words = new StreamReader(Console.ReadLine());
           Console.Write("Enter path to test.txt: ");
           StreamReader textFile = new StreamReader(Console.ReadLine());
           string wordsStr = words.ReadToEnd();
           string text = textFile.ReadToEnd();
           List<string> wordsList = wordsStr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
           List<string> textList = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
           Dictionary<string, int> indexWord = new Dictionary<string, int>();
           int counter = 0;
           for (int i = 0; i < wordsList.Count; i++)
           {
               for (int j = 0; j < textList.Count; j++)
               {
                 if(textList[j] == wordsList[i])
                 {
                     counter++;
                 }
               }
               indexWord.Add(wordsList[i], counter);
               counter = 0;
           }
           var sortedDict = from entry in indexWord orderby entry.Value descending select entry;
           StringBuilder newText = new StringBuilder();
           foreach(var indexAndWord in sortedDict)
           {
               newText.AppendLine(indexAndWord.ToString());
           }
           newText.Replace(",", " -");
           newText.Replace("[", "");
           newText.Replace("]", " times");
           Console.Write("Enter path to result.txt: ");
           StreamWriter write = new StreamWriter(Console.ReadLine());
           write.Write(newText);
           write.Flush();
           Console.WriteLine("File is written!");
       }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("File can't be load!");
        }
        catch(EndOfStreamException)
        {
            Console.WriteLine("Stream not closed!");
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("Directory can't be found!");
        }
        catch(AccessViolationException)
        {
            Console.WriteLine("This file is part of protected memory and can't be read!");
        }
        catch(Exception)
        {
            Console.WriteLine("Something is terribly wrong :(");
        }
    }
}

