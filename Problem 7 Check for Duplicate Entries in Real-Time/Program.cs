using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> dataEntries = new HashSet<string>();
        string[] entries = { "A", "B", "C", "A", "B", "C", "D", "F", "R" };
        foreach (var entry in entries)
        {
            if (!dataEntries.Add(entry))
            {
                Console.WriteLine($"Duplicate detected: {entry}");
            }
        }
        Console.ReadKey();
    }
}

