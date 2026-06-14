using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>(new[] { 1, 2, 3, 4 });
        HashSet<int> set2 = new HashSet<int>(new[] { 3, 4, 5, 6 });

        set1.ExceptWith(set2);

        Console.WriteLine($"{string.Join(", ", set1)}");
    }
}

