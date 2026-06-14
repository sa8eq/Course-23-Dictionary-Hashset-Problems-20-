using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static HashSet<int> GetFrequentNumbers(int[] nums)
    {
        Dictionary<int, int> r = new Dictionary<int, int>();
        HashSet<int> result = new HashSet<int>();
        foreach(int num in nums)
        {
            if(!r.ContainsKey(num))
            {
                r[num] = 0;
            }

            r[num]++;

            if (r[num]==2)
            {
                result.Add(num);
            }
        }
        
        return result;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 3, 5, 7, 9 };
        foreach(var i in GetFrequentNumbers(nums))
        {
            Console.WriteLine($"Element: {i}");
        }
    }
}

