using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class PeakIndexInMountainArray
    {
        public static int PeakingIndexMountainArray(int[] arr)
        {
            int mid, left = 0, right = arr.Length - 1;

            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (arr[mid] < arr[mid + 1])
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}
