namespace Maximum_Average_Subarray_I
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMaxAverage([4, 0, 4, 3, 3], 5));

            Console.ReadLine();
        }

        public static double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            maxSum = sum;

            for ( int i = k; i < nums.Length; i++)
            {
                sum -= nums[i - k];
                sum += nums[i];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum / (double)k;
        }
    }
}
