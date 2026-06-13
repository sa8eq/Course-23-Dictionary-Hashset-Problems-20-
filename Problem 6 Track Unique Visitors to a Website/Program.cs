using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> visitors = new HashSet<string>();

        visitors.Add("Sadeq");
        visitors.Add("Omar");
        visitors.Add("Sadeq");
        visitors.Add("Asmaa");
        visitors.Add("Ahmed");
        visitors.Add("Linah");
        visitors.Add("Ahmed");
        visitors.Add("Noor");
        visitors.Add("Asmaa");
        visitors.Add("Ahmed");
        visitors.Add("Linah");
        visitors.Add("Ahmed");
        visitors.Add("Noor");
        int i = 0;


        foreach (string v in visitors)
        {
            i++;
            Console.WriteLine($"Visitor Number: {i} Is {v}");
        }
        Console.WriteLine($"Number Of Unique Visitors: {visitors.Count}");
    }
}

