using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MaximumAverageSubarrayI
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            int currentSum = 0;
            int sum = 0;

            for(int i =0; i<nums.Length-k;i++)
            {
                currentSum = nums.Take(k).Sum() - i * nums[i];
            }

            return 0;

            
        }
    }
}
