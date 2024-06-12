namespace Longest_Common_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LongestCommonSubsequence("abcde", "ace");
        }

        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int len1 = text1.Length + 1;
            int len2 = text2.Length + 1;
            var memo = new int[len1, len2];
            
            for (int i = 1; i < len1; i++)
            {
                for (int j = 1; j < len2; j++)
                {
                    if (text1[i - 1] == text2[j - 1]) memo[i, j] = memo[i - 1, j - 1] + 1;
                    else memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                }
            }

            return memo[len1 - 1, len2 - 1];
        }
    }
}
