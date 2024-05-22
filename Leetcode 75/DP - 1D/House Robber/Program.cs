namespace House_Robber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int Rob(int[] nums)
        {
            int len = nums.Length;
            if (len == 1) return nums[0];
            if (len == 2) return Math.Max(nums[0], nums[1]);
            if (len == 3) return Math.Max(nums[0] + nums[2], nums[1]);

            var memo = new int[len + 1];
            memo[0] = 0;
            memo[1] = nums[0];
            memo[2] = nums[1];

            for (int i = 3; i < memo.Length; i++)
            { 
                memo[i] = nums[i - 1] + Math.Max(memo[i - 2], memo[i - 3]);
            }

            return Math.Max(memo[len], memo[len - 1]);
        }
    }
}
