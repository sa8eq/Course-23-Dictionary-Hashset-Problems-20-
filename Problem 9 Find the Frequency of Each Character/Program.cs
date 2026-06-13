using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static Dictionary<char, int> Count(string word)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach(char i in word)
        {
            if (i != ' ')
            {
                if (freq.ContainsKey(i))
                {
                    freq[i]++;
                }
                else
                {
                    freq[i] = 1;
                }
            }
        }
        return freq;
    }
    static void Main(string[] args)
    {
        Dictionary<char, int> freq = Count("Hello World");

        foreach (var i in freq)
        {
            Console.WriteLine($"Letter: {i.Key}, Frequency: {i.Value}");
        }
    }
}

