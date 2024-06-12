namespace Single_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int SingleNumber(int[] nums)
        {
            int ans = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                ans ^= nums[i];
            }

            return ans;
        }
    }
}
