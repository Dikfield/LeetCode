using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class NextGreaterElementI
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] ans = new int[nums1.Length];
            int higher = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                higher = int.MaxValue;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        higher = nums1[i];
                    }
                    if (higher < nums2[j])
                    {
                        ans[i] = nums2[j];
                        j = nums2.Length;
                    }
                    else if (nums2[j] == nums2[nums2.Length - 1])
                        ans[i] = -1;


                }
            }
            return ans;
        }
    }
}
