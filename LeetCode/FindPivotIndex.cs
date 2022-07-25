using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class FindPivotIndex
    {
        public static int PivotIndex(int[] nums)
        {
            int left = 1;
            int right = nums.Length - 1;
            int sumLeft = nums[0];
            int sumRight = nums[nums.Length - 1];

            if (nums.Sum() - nums[0] == 0)
                return 0;

            else
            {
                while (left < right)
                {
                    if (Math.Abs(sumLeft) <= Math.Abs(sumRight))
                    {

                        sumLeft += nums[left];
                        left++;
                    }
                    else
                    {
                        right--;
                        sumRight += nums[right];
                    }
                    

                    if (sumLeft == sumRight)
                        return left;
                }
            }

            return -1;
        }
    }
}
