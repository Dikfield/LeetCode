using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestConsecutiveSentence
    {
        public static int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            int count = 1;
            int currentCount = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i + 1 != null && nums[i + 1] == nums[i] + 1)
                {
                    currentCount++;

                    if (currentCount > count)
                        count = currentCount;
                }

                else if (i + 1 != null && nums[i + 1] == nums[i])
                    continue;
                else
                    currentCount = 1;


            }

            if (nums.Length == 0)
                return 0;
            return count;
        }
    }
}
