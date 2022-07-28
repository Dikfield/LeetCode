using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class OccurrencerAfterBigram
    {
        public static string[] FindOcurrences(string text, string first, string second)
        {
            bool firstWord = false;
            bool secondWord = false;
            string word = "";
            string[] ans = new string[2];
            int index = 0;
            text += " ";
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == ' ' && word == first && firstWord == false)
                {
                    firstWord = true;
                    word = "";
                }
                else if (text[i] == ' ' && word == second && firstWord == true && secondWord == false)
                {
                    secondWord = true;
                    word = "";
                }
                else if (text[i] != ' ' && firstWord == true && secondWord == true)
                {
                    word += text[i];
                }
                else if (text[i] == ' ' && word.Length > 0 && firstWord == true && secondWord == true)
                {
                    ans[index] = word;
                    index++;
                    
                    if(word != first)
                        firstWord = false;

                    if(word != second)
                        secondWord = false;
                    word = "";
                    
                }
                else if (text[i] == ' ')
                    word = "";
                else
                    word += text[i];



            }

            return ans;
        }
    }
}
