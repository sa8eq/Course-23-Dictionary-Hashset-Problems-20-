using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> words = new Dictionary<string, string>();
        words.Add("Hello","Hola");
        words.Add("GoodBye", "Adios");

        Console.WriteLine($"hello in spanish is: {words["Hello"]}");
        Console.WriteLine($"goodbye in spanish is: {words["GoodBye"]}");
    }
}

