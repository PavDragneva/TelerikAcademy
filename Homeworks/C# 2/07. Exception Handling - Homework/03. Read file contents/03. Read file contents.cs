using System;
using System.IO;
/*•	Write a program that enters file name along with its full file path 
         * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
          •	Find in MSDN how to use System.IO.File.ReadAllText(…).
          •	Be sure to catch all possible exceptions and print user-friendly error messages.*/
class ReadFileContents
{
    static void Main()
    {
        try
        {
            Console.Write("Enter full file path: ");
            StreamReader file = new StreamReader(Console.ReadLine());
            string text = file.ReadToEnd();
            file.Close();
            Console.WriteLine(text);
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