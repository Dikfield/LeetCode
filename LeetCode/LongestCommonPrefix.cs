using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPref(string[] strs)
        {
            string ans = "";
            int count = 0;
            string store ="";
            string storeCompare = "";
            for (int i = 0; i < strs.Length; i++)
            {
                if (i + 1 < strs.Length && strs[i].Contains(strs[i + 1]) && store == "")
                    store = string.Concat(strs[i].Intersect(strs[i + 1]).ToArray());
                else if (i + 1 < strs.Length && store == string.Concat(strs[i].Intersect(strs[i + 1]).ToArray()))
                {
                    continue;
                }
                else
                    if(i+1 < strs.Length)
                {
                    storeCompare = string.Concat(store.Intersect(string.Concat(strs[i + 1])).ToArray());

                    if (storeCompare == store)
                        store = storeCompare;
                    
                }
                    
            }
            return store;
        }
    }
}
