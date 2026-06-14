using System;
using System.Collections.Generic;

class Program
{
    static List<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        List<int> result = new List<int>();
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
                result.Add(i);
        }
        return result;
    }
    static void Main()
    {
        int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
        var result = FindDisappearedNumbers(nums);
        Console.WriteLine(string.Join(", ", result));
        Console.ReadKey();
    }
}
