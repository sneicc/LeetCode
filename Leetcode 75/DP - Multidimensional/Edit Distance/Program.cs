namespace Edit_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MinDistance(string word1, string word2)
        {
            int w1Len = word1.Length;
            int w2Len = word2.Length;
            var memo = new int[w1Len + 1, w2Len + 1];
            
            for (int i = 1; i <= w1Len; i++)
            {
                memo[i, 0] = i;
            }
            for (int j = 1; j <= w2Len; j++)
            {
                memo[0, j] = j;
            }
            memo[0, 0] = 0;

            for (int i = 1; i <= w1Len; i++)
            {
                for (int j = 1; j <= w2Len; j++)
                {
                    if (word1[i - 1] == word2[j - 1]) memo[i, j] = memo[i - 1, j - 1];
                    else 
                    {
                        int min = Math.Min(memo[i - 1, j - 1], memo[i - 1, j]);
                        min = Math.Min(min, memo[i, j - 1]);
                        memo[i, j] = min + 1;
                    }
                }
            }

            return memo[w1Len, w2Len];
        }
    }
}
