namespace Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int MaxVowels(string s, int k)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            int currentMax = 0;
            int max = 0;

            for (int i = 0; i < k; i++)
            {
                foreach (char vowel in vowels)
                {
                    if (s[i] == vowel)
                    {
                        currentMax++;
                        break;
                    }
                }
            }
            
            max = currentMax;
            for (int i = k; i < s.Length; i++)
            {
                foreach (char vowel in vowels)
                {
                    if (s[i - k] == vowel)
                    {
                        currentMax--;
                    }

                    if (s[i] == vowel)
                    {
                        currentMax++;
                    }
                }
                max = Math.Max(currentMax, max);
            }

            return max;
        }
    }
}
