using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Strings_Alternately
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine(MergeAlternately("abcd", "pq"));

            Console.ReadLine();
        }

        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();

            int minLen = word1.Length < word2.Length ? word1.Length : word2.Length;
            for (int i = 0; i < minLen; i++)
            {
                sb.Append(word1[i]).Append(word2[i]);                
            }

            if((word1 != word2) && (word1.Length > word2.Length))
            {
                for(int i = minLen; i < word1.Length; i++)
                {
                    sb.Append(word1[i]);
                }         
            }
            else
            {
                for (int i = minLen; i < word2.Length; i++)
                {
                    sb.Append(word2[i]);
                }
            }

            return sb.ToString();
        }
    }
}
