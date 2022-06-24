using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class CountNegativeNumbersInaSortedMatrix
    {
        public static int CountNegativeNumbersInaSortedMatrix1(int[][] grid)
        {
            int count = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for( int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] <0)
                        count++;
                }
            }
            return count;
        }

    }
}
