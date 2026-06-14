using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6 };


        bool IsDistinct = true;

        foreach(int i in set1)
        {
            if (set2.Contains(i))
                IsDistinct = false;
        }

        Console.WriteLine("Are The Two Set Distinct? " + IsDistinct);
    }
}

