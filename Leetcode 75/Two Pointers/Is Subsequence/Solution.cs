namespace Is_Subsequence
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            IsSubsequence("abc", "ahbgdc");

            Console.ReadKey();
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (t.Length == 0 && s.Length == 0) 
                return true;
            if(t.Length == 0)
                return false;
            if(s.Length == 0) 
                return true;

            int sIndex = 0;

            foreach (var letter in t)
            {
                if (s[sIndex] == letter)
                {
                    sIndex++;

                    if (sIndex == s.Length)
                        return true;
                }
            }

            return false;
        }
    }
}
