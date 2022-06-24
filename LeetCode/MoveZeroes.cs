using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MoveZeroes
    {
        public static int[] MoveZeros(int[] nums)
        {
            int nonZero = 0;
            int zero = 0;
            for(int i =0; i< nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[nonZero++] = nums[i];
                else
                    zero++;
            }          

            while(zero > 0)
            {
                nums[^zero] = 0;
                zero--;
            }
            
            return nums;
        }
    }
}
