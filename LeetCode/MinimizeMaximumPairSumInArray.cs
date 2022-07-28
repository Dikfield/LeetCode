using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MinimizeMaximumPairSumInArray
    {
        public static int MinPairSum(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int currentSum = 0;
            int sum = 0;
            nums = nums.OrderByDescending(a => a).ToArray();

            while (left < right)
            {
                currentSum = nums[left] + nums[right];

                if (currentSum > sum)
                    sum = currentSum;

                left++;
                right--;
            }

            return sum;
        }
    }
}
