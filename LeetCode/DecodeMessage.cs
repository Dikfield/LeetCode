using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class DecodeMessage
    {
        public static string Decode(string key, string message)
        {
            Dictionary<char, char> Decriptor = new Dictionary<char, char>();

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string ans = "";
            
            key = String.Concat(key.Where(c => !Char.IsWhiteSpace(c)));


            for (int i =0; i<alpha.Length; i++)
            {
                for(int j =i; j<key.Length;j++)
                {
                    if (Decriptor.ContainsKey(key[j]) == false)
                    {
                        Decriptor.Add(key[j], alpha[i]);
                        j = key.Length;
                        
                    }
                    else
                    {
                        
                    }
                        
                }
            }

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                    ans += " ";
                else
                    ans += Decriptor[message[i]];
            }

            return ans;
        }
    }
}
