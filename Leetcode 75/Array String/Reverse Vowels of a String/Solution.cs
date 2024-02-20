using System.Text;

namespace Reverse_Vowels_of_a_String
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels("Hello"));

            Console.ReadLine();
        }

        public static string ReverseVowels(string s)
        {
            var ans = new StringBuilder(s);
            var positions = new List<int>();
            var foundVowels = new List<char>();
            char[] vowels = ['A', 'E', 'I', 'O', 'U'];

            for (int i = 0; i < s.Length; i++)
            {
                foreach (char vowel in vowels)
                {
                    if (Char.ToUpper(s[i]) == vowel)
                    {
                        positions.Add(i);
                        foundVowels.Add(s[i]);
                        break;
                    }
                }
            }
            
            int reverseCounter = positions.Count - 1;
            for (int i = 0; i < positions.Count; i++)
            {
                ans[positions[i]] = foundVowels[reverseCounter--];
            }

            return ans.ToString();
        }
    }
}
