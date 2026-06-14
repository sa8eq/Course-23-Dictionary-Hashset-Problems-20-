using System;
using System.Collections.Generic;
class Program
{
    static string[] FindWords(string[] words)
    {
        string[] row = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        Dictionary<char, int> rownum = new Dictionary<char, int>();
        for (int i = 0; i < row.Length; i++)
        {
            foreach(char v in row[i])
            {
                rownum[v] = i;
            }
        }
        List<string> result = new List<string>();
        foreach (string word in words)
        {
            bool IsValid = true;
            int rown= rownum[char.ToLower(word[0])];

            foreach(char c in word)
            {
                if (rownum[char.ToLower(c)]!=rown)
                {
                    IsValid = false;
                    break;
                }
            }

            if(IsValid)
            {
                result.Add(word);
            }
        }
        return result.ToArray();
    }
    static void Main()
    {
        string[] words = { "Hello", "Alaska", "Dad", "Peace" };
        Console.WriteLine(string.Join(", ", FindWords(words)));
        Console.ReadKey();


    }
}
