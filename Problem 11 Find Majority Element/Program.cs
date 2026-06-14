using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    public static (int element,int frequency) FindMajorityElement(int[] nums)
    {
        Dictionary<int, int> me = new Dictionary<int, int>();
        int majority = nums.Length / 2;
        for (int i = 0; i < nums.Length; i++)
        {
            if(!me.ContainsKey(nums[i]))
            {
                me.Add(nums[i],0);
            }

            me[nums[i]]++;
            
            if (me[nums[i]] > majority)
            {
                return (nums[i], me[nums[i]]);
            }
        }
        return (0, 0);
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 1, 1, 5, 8 };
        (int element, int frequency) = FindMajorityElement(nums);
        Console.WriteLine(element + " repeted " + frequency + " times");
   
    }
}

