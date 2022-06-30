using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class CoutingWordsWithGivenPrefix
    {
        public static int CoutingWords(string[] words, string pref)
        {
            int count = 0;
            int count2 = 0;
            int countPref = 0;
            for (int i = 0; i < words.Length; i++)
            {
                count = 0;

                if (words[i][0] == pref[0])
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (countPref < pref.Length)
                        {
                            if (words[i][j] == pref[countPref++])
                            {
                                count++;

                                if (count == pref.Length)
                                {
                                    count2++;
                                    countPref = 0;
                                }
                            }
                            else
                            {
                                j = words[i].Length;
                                countPref = 0;
                            }
                        }
                        else
                        {
                            j = words[i].Length;
                            countPref = 0;
                        }
                    }
                }
            }
            return count2;
        }
    }
}
