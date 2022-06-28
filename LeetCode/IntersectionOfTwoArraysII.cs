using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class IntersectionOfTwoArraysII
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {

            List<int> listinha = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int count = 0;
            for (int i = 0; i < nums1.Length; i++)
            {

                int ans = BinarySearch(nums1[i], nums2);
                if (ans != -1)
                {
                    listinha.Add(ans);
                    count++;
                }


                if (count == nums2.Length)
                    return listinha.ToArray();
            }

            return listinha.ToArray();
        }

        private static int BinarySearch(int i, int[] nums2)
        {

            int left = 0;
            int right = nums2.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (i == nums2[mid]) return nums2[mid];
                else if (nums2[mid] > i)
                    right = mid - 1;
                else
                    left = mid + 1;

            }
            return -1;
        }
    }
}
