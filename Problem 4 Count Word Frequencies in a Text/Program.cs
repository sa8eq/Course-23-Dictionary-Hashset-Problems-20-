using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static Dictionary<string, int> CountWords(string txt)
    {
        
        Dictionary<string, int> words = new Dictionary<string, int>();
        string remainingtxt = txt;
        string word = "";
        for (int i = 0; i < remainingtxt.Length; i++)
        {
            if (char.IsWhiteSpace(remainingtxt[i]))
            {
                word = remainingtxt.Substring(0, i);
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(remainingtxt.Substring(0, i), 1);
                }
                remainingtxt = remainingtxt.Remove(0, i + 1);
                i = 0;
            }
        }
        if (remainingtxt.Length != 0)
        {
            if(words.ContainsKey(remainingtxt))
            {
                words[remainingtxt]++;
            }
            else
            {
                words.Add(remainingtxt, 1);
            }
        }
        Console.WriteLine(remainingtxt);
        Console.WriteLine(words.Count);
        return words;
    }
    static void Main(string[] args)
    {
        //Dictionary<string, int> words = CountWords("hello world hello universe hello jeddah");
        //foreach (var i in words)
        //{
        //    Console.WriteLine($"Word: {i.Key}, Repetition: {i.Value}");
        //}

        string text = "hello world hello universe";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (var word in text.Split(' '))
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }
        foreach (var word in wordCount)
        {
            Console.WriteLine($"{word.Key}: {word.Value}");
        }
        Console.ReadKey();
    }
}

