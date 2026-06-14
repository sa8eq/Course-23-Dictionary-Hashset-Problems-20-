using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static int MissingNumber(int[] numbers)
    {
        return ((numbers.Length * (numbers.Length + 1)) / 2) - numbers.Sum();
    }
    public static int MissingNumber()
    {
        int[] nums = { 1, 2, 4, 5, 6 };



        HashSet<int> set = new HashSet<int>(nums);
        int n = nums.Length;


        for (int i = 0; i <= n; i++)
        {
            if (!set.Contains(i))
                return i;
        }

        return -1;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(MissingNumber());
    }
}

