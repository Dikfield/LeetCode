using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class AverageSalaryExcludingtheMinimumandMaximumSalary
    {
        public static double AverageSalary(int[] salary)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            int left = 0;
            int right = salary.Length - 1;
            int sum = 0;
            while (left <= right)
            {
                sum += salary[left];
                if (max > salary[left]) max = salary[left];
                if (min < salary[left]) min = salary[left];
                left++;
            }

            int total = sum - min - max;

            return (double)(total / (salary.Length - 2));
        }
    }
}
