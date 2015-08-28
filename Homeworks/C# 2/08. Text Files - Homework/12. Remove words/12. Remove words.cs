using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that removes from a text file all words listed in given another text file.
//•	Handle all possible exceptions in your methods.
class RemoveWords
{
    static void Main()
    {
        try
        {
            Console.Write("Enter path to the file: ");
            string path = Console.ReadLine();
            StreamReader reader = new StreamReader(path);
            Console.Write("Enter path to the file with words separeted by comma: ");
            StreamReader wordsRemove = new StreamReader(Console.ReadLine());
            string wordsStr = wordsRemove.ReadToEnd();
            string text = reader.ReadToEnd();
            List<string> listRemove = wordsStr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> textList = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < listRemove.Count; i++)
            {
                for (int j = 0; j < textList.Count; j++)
                {
                    if (listRemove[i] == textList[j])
                    {
                        textList[j] = null;
                    }
                }
            }
            text = string.Join(" ", textList);
            textList.Clear();
            textList = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            text = string.Join(" ", textList).ToString();
            reader.Close();
            StreamWriter writer = new StreamWriter(path);
            writer.Write(text);
            writer.Flush();
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
        catch (EndOfStreamException)
        {
            Console.WriteLine("Stream not closed!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory can't be found!");
        }
        catch (AccessViolationException)
        {
            Console.WriteLine("This file is part of protected memory and can't be read!");
        }
        catch (Exception)
        {
            Console.WriteLine("Something is terribly wrong :(");
        }
    }
}

