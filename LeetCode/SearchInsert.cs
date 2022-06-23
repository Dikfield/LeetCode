using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class SearchInsert
    {
        public static int SearchingInsert(int[] nums, int target)
        {
            int mid, left = 0, right = nums.Length-1;

            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;

            }
            return left;

        }
    }
}
