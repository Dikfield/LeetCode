using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class CheckIfNumbersAreAscending
    {
        public static bool AreNumbersAscending(string s)
        {
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    if ((s[i] - '0') > number)
                    {
                        number = s[i] - '0';
                        continue;
                    }
                    else if (i + 1 != 0 && Char.IsDigit(s[i + 1]))
                    {
                        if ((s[i] - '0') > number)
                        {
                            number = s[i] - '0';
                            continue;
                        }
                        else if (i < s.Length - 1)
                        {
                            if (((s[i] + s[i + 1]) - '0' > number))
                            {
                                number = s[i] - '0';
                                continue;
                            }
                        }

                        else
                            return false;
                    }
                    
                        
                }

            }

            return true;
        }
    }
}
