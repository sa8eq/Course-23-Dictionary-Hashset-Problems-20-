using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static List<int> UniqueElements(int[] nums)
    {
        Dictionary<int, int> r = new Dictionary<int, int>();
        List<int> unique = new List<int>();
        foreach(int num in nums)
        {
            if (!r.ContainsKey(num))
            {
                r[num] = 0;
            }

            r[num]++;
        }
        foreach(var i in r)
        {
            if(i.Value==1)
            {
                unique.Add(i.Key);
            }
        }

        return unique ;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 2, 3, 4, 5, 3 };
        foreach(var i in UniqueElements(nums))
        {
            Console.WriteLine(i);
        }
    }
}

