using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, (string Title, string Author)> books = new Dictionary<string, (string, string)>();
        books.Add("978-3-16-148410-0", ("The Great Gatsby", "F. Scott Fitzgerald"));
        books.Add("978-1-61-729494-5", ("C# in Depth", "Jon Skeet"));

        foreach(var i in books)
        {
            Console.WriteLine($"ISBN: {i.Key}, Title: {i.Value.Title}, Author: {i.Value.Author}");
        }
    }
}

