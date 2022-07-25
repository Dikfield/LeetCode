using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class DecompressRunLengthEncodedList
    {
        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> test = new List<int>();
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    k = nums[i];
                else
                {
                    while (k > 0)
                    {
                        test.Add(nums[i]);
                        k--;
                    }
                }
            }

            return test.ToArray();
        }
    }
}
