namespace Kids_With_the_Greatest_Number_of_Candies
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            foreach (var x in KidsWithCandies([4, 2, 1, 1, 2], 1))
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int length = candies.Length;
            var ans = new bool[length];

            int maxCandies = candies.Max();

            for (int i = 0; i < length; i++)
            {
                    ans[i] = candies[i] + extraCandies >= maxCandies;
            }

            return ans;
        }
    }
}
