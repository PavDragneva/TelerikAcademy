using System;
/*•	Write a program that parses an URL address given in the format:
         * [protocol]://[server]/[resource] and extracts from it the [protocol],
         * [server] and [resource] elements.*/
class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL address: ");
        var url = new Uri(Console.ReadLine());
        string protocol = url.Scheme;
        Console.WriteLine("Protocol - {0}", protocol);
        string server = url.Authority;
        Console.WriteLine("Server - {0}", server);
        string resource = url.PathAndQuery;
        Console.WriteLine("Resource - {0}", resource);
    }
}
