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


            return nums.Take(k).Sum();
        }
    }
}
