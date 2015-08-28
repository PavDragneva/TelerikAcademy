using System;
using System.Net;
/*•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the 
        * current directory.
         •	Find in Google how to download files in C#.
         •	Be sure to catch all exceptions and to free any used resources in the finally block.*/
class DownloadFile
{
    static void Main()
    {
        try
        {
            WebClient you = new WebClient();
            you.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "D:\\");

        }
        catch(Exception)
        {
            Console.WriteLine("Something is terrebly wrong!");
        }
    }
}

