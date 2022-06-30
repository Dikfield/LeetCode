using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ReverseString
    {
        public static char[] ReverseStringAns(char[] s)
        {
            int a = 0;
            int b = s.Length - 1;
            char c;

            while (b > a)
            {
                c = s[a];
                s[a] = s[b];
                s[b] = c;

                a++;
                b--;
            }
            return s;
        }
    }
}
