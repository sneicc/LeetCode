namespace Min_Cost_Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MinCostClimbingStairs(int[] cost)
        {           
            var dp = new int[cost.Length + 1];
            dp[cost.Length] = 0;
            dp[cost.Length - 1] = cost[cost.Length - 1];

            for (int i = cost.Length - 2; i >= 0 ; i--)
            {
                dp[i] = cost[i] + Math.Min(dp[i + 1], dp[i + 2]);
            }

            return Math.Min(dp[0], dp[1]);
        }
    }
}
