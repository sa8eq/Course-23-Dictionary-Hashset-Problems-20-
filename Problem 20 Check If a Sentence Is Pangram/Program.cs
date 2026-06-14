using System;
using System.Collections.Generic;

class Program
{
    static bool IsPangram(string sentence)
    {
        HashSet<char> letters = new HashSet<char>();
        foreach (char c in sentence.ToLower())
        {
            if (char.IsLetter(c))
                letters.Add(c);
        }
        return letters.Count == 26;
    }
    static void Main()
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine(IsPangram(sentence)); 
        Console.ReadKey();
    }
}