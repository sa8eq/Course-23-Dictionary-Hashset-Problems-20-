using System;
using System.Collections.Generic;
using System.ComponentModel;
class Program
{
    static int LongestConsecutive(int[] Nums)
    {
        HashSet<int> nums = new HashSet<int>(Nums);
        int longerStreak = 0;
        foreach (int num in nums)
        {
            if (!nums.Contains(num - 1))
            {
                int currentnum = num;
                int currentstreak = 1;
                while (nums.Contains(currentnum + 1))
                {
                    currentstreak++;
                    currentnum++;

                }
                longerStreak = Math.Max(longerStreak, currentstreak);
            }
        }
        return longerStreak;
    }
    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2, 5, 101, 102 };
        Console.WriteLine(LongestConsecutive(nums)); // Output: 4
        Console.ReadKey();
    }
}
